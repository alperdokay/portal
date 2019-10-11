using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class TeamMember : DeletableEntity
    {
        public virtual string FullName { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual int Role { get; set; }
        public virtual int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public virtual TeamMember Team { get; set; }
        public virtual string IdentificationNumber { get; set; }
        public virtual int Gender { get; set; }
        public virtual bool isHealthProblem { get; set; }
        public virtual string Explanation { get; set; }
        public virtual string isKVKKAccepted { get; set; }
    }
}
