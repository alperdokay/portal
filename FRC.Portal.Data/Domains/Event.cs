using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class Event : DeletableEntity
    {
        public virtual string EventName { get; set; }
        public virtual string EventDate { get; set; }
        public virtual string Location { get; set; }
        public virtual int Type { get; set; }
    }
}
