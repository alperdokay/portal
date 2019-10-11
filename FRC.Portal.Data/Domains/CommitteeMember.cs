using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class CommitteeMember : DeletableEntity
    {
        public virtual int Role { get; set; }
        public virtual int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual DateTime ParticipationYear { get; set; }
        public virtual bool isActive { get; set; }
    }
}
