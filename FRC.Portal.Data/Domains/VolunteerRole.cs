using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class VolunteerRole : DeletableEntity
    {
        public virtual string Role { get; set; }
    }
}
