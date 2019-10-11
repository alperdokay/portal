using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;
using FRC.Portal.Common.Enums;

namespace FRC.Portal.Data.Domains
{
    public class Account : DeletableEntity
    {
        // Each variable represents a column from Team table in SQL
        public virtual string FullName { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual EnumAccountType UserRole { get; set; }
        public virtual string UserImage { get; set; }
    }
}
