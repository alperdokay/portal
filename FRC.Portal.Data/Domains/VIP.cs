using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class VIP : DeletableEntity
    {
        public virtual string FullName { get; set; }
        public virtual string Institution { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string MailingAddress { get; set; }
        public virtual string City { get; set; }
        public virtual string District { get; set; }
        public virtual int TeamId { get; set; }
        public virtual TeamMember Team { get; set; }
    }
}
