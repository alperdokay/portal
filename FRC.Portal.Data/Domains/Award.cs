using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Data.Models;

namespace FRC.Portal.Data.Domains
{
    public class Award : DeletableEntity
    {
        public virtual string AwardName { get; set; }
        public virtual bool isChamp { get; set; }
        public virtual bool isRookie { get; set; }
    }
}
