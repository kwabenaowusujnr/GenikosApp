using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using GenikosApp.Models;
using System.Data;
using System.Diagnostics;

namespace GenikosApp.Data
{
    public class DatabaseConnection
    {
        SqlTransaction _Transaction;
        public AppSettingModel app = new AppSettingModel(); 
        public String _ConnectionString;
        private static int _Timeout = 1000000;



        public DatabaseConnection()
        {
            _ConnectionString = app.dbconnection;
        }

        public string DateFormat(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }

        private void CheckSQLLength(string sql)
        {
            //Guard against a SqlCommand cutting off CommandText because too long.
            if (sql.Length > 8000)
                throw new ApplicationException("SQL string is too long. [SQL=" + sql.Substring(0, 30) + "...]");
        }

        private SqlConnection GetConnection()
        {
            if (_Transaction != null)
                return _Transaction.Connection;
            SqlConnection connect = new SqlConnection(_ConnectionString);
            connect.Open();
            return connect;
        }

        private void CloseConnection(SqlConnection connection)
        {
            if (_Transaction == null)
            {
               //connection.Close();
                connection.Dispose();
            }
        }
        private void CloseTransaction()
        {
            if (_Transaction.Connection != null)
            {
                _Transaction.Connection.Close();
                _Transaction.Connection.Dispose();
            }
            _Transaction.Dispose();
            _Transaction = null;
        }

        public void BeginTran()
        {
            if (_Transaction != null)
                throw new ApplicationException("Should not call BeginTran when already in a Transaction!");
            SqlConnection connect = GetConnection();
            try
            {
                _Transaction = connect.BeginTransaction();
            }
            catch
            {
                connect.Close();
                CloseConnection(connect);
            }
        }
        public void Commit()
        {
            if (_Transaction == null)
                throw new ApplicationException("Should not call Commit when not in a Transaction!");
            try
            {
                _Transaction.Commit();
            }
            finally
            {
                CloseTransaction();
            }
        }
        public void Rollback()
        {
            if (_Transaction == null)
                throw new ApplicationException("Should not call Rollback when not in a Transaction!");
            try
            {
                _Transaction.Rollback();
            }
            finally
            {
                CloseTransaction();
            }
        }

        public DataTable Get(string sql)
        {
            CheckSQLLength(sql);
            return GetDataSet(new SqlCommand(sql)).Tables[0];
        }
        public DataTable Get(SqlCommand cmd)
        {
            CheckSQLLength(cmd.CommandText);
            return GetDataSet(cmd).Tables[0];
        }
        public DataSet GetDataSet(SqlCommand cmd)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            SqlConnection connect = GetConnection();
            cmd.CommandTimeout = _Timeout;
            SetToStoredProcedureIfAppropriate(cmd);
            try
            {
                a.SelectCommand = cmd;
                cmd.Connection = connect;
                a.SelectCommand.Transaction = _Transaction;
                DataSet ds = new DataSet();
                a.Fill(ds);
                return ds;
            }
            catch (SqlException x)
            {
                Debug.WriteLine("SQL Exception: " + x.Message);
                throw;
            }
            finally
            {
                CloseConnection(connect);
            }
        }

        public object GetScalar(SqlCommand cmd)
        {
            SqlDataAdapter a = new SqlDataAdapter();
            SqlConnection connect = GetConnection();
            cmd.CommandTimeout = _Timeout;
            SetToStoredProcedureIfAppropriate(cmd);
            try
            {
                a.SelectCommand = cmd;
                cmd.Connection = connect;
                a.SelectCommand.Transaction = _Transaction;
                object o = cmd.ExecuteScalar();
                if (o == null || o.Equals(DBNull.Value))
                    return null;
                return o;
            }
            catch (SqlException x)
            {
                Debug.WriteLine("SQL Exception: " + x.Message);
                throw;
            }
            finally
            {
                CloseConnection(connect);
            }
        }

        public object GetScalar(string sql)
        {
            CheckSQLLength(sql);
            SqlConnection connect = GetConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Transaction = _Transaction;
                object o = cmd.ExecuteScalar();
                if (o == null || o.Equals(DBNull.Value))
                    return null;
                return o;
            }
            catch (SqlException x)
            {
                Debug.WriteLine("SQL Exception: " + x.Message);
                throw;
            }
            finally
            {
                CloseConnection(connect);
            }
        }

        public void Execute(string sql)
        {
            CheckSQLLength(sql);
            SqlConnection connect = GetConnection();
            try
            {
                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = connect;
                cmd.Transaction = _Transaction;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException x)
            {
                Debug.WriteLine("SQL Exception: " + x.Message);
                throw;
            }
            finally
            {
                CloseConnection(connect);
            }
        }

        public void Execute(SqlCommand cmd)
        {
            CheckSQLLength(cmd.CommandText);
            SetToStoredProcedureIfAppropriate(cmd);
            SqlConnection connect = GetConnection();
            try
            {
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connect.State != ConnectionState.Closed)
                {
                    connect.Close();
                }
            }
        }

        private void SetToStoredProcedureIfAppropriate(SqlCommand cmd)
        {
            if (cmd.CommandText.Contains(" "))
                cmd.CommandType = CommandType.Text;
            else
                cmd.CommandType = CommandType.StoredProcedure;
        }

        public string Escape(string value)
        {
            return value.Replace("'", "''");
        }

        public string CommaDelimit(Array a)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < a.Length; j++)
            {
                sb.Append(a.GetValue(j));
                if (j < a.Length - 1)
                    sb.Append(',');
            }
            return sb.ToString();
        }
        public SqlDataReader GetDataReader(SqlCommand command)
        {
            var connect = GetConnection();

            try
            {
                SetToStoredProcedureIfAppropriate(command);
                command.Connection = connect;
                return command.ExecuteReader();
            }
            catch (SqlException x)
            {
                Debug.WriteLine("SQL Exception: " + x.Message);
                throw;
            }
        }
       
      


       
        

    }
}
