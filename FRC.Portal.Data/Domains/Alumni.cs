using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class Alumni : DeletableEntity
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string IdentificationNumber { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual int Gender { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Email { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string District { get; set; }
        public virtual string EducationalBackground { get; set; }
        public virtual string GraduatedFrom { get; set; }
        public virtual int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
        public virtual string TeamInfo { get; set; }
    }
}
