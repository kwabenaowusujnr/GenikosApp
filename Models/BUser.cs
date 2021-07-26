using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GenikosApp.Models
{
    public class BUser
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "Username")]
        public string UserName { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "OrganizationId")]
        public Int64 OrganizationId { get; set; }

        [DataMember(Name = "OrgName")]
        public string OrgName { get; set; }

        [DataMember(Name = "OrgType")]
        public string OrgType { get; set; }

        [DataMember(Name = "RoleName")]
        public string RoleName { get; set; }

        [DataMember(Name = "NormalisedRole")]
        public string Rolenormname { get; set; }

        [DataMember(Name = "CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [DataMember(Name = "CreatedBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "RoleId")]
        public string RoleId { get; set; }


        [DataMember(Name = "Password")]
        public string Password { get; set; }

        [DataMember(Name = "NewPassword")]
        public string NewPassword { get; set; }
    }
}
