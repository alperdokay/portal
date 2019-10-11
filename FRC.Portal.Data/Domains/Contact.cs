using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class Contact : DeletableEntity
    {
        public virtual string Facebook { get; set; }
        public virtual string Twitter { get; set; }
        public virtual string Instagram { get; set; }
        public virtual string Website { get; set; }
        public virtual string YouTube { get; set; }
    }
}
