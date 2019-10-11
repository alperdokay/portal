using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class Team : DeletableEntity
    {
        // Each variable represents a column from Team table in SQL
        [MaxLength(500)]
        public virtual string TeamName { get; set; }
        [MaxLength(500)]
        public virtual string TeamNumber { get; set; }
        [MaxLength(500)]
        public virtual string School { get; set; }
        [MaxLength(100)]
        public virtual string Email { get; set; }
        public virtual DateTime RookieYear { get; set; }
        public virtual string City { get; set; }
        public virtual string District { get; set; }
        public virtual string SchoolType { get; set; }
        public virtual int Status { get; set; }
        public virtual int AccountId { get; set; }
        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
    }
}
