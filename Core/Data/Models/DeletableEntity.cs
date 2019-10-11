using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Models
{
    public class DeletableEntity : DeletableEntityBase
    {
        [ScaffoldColumn(false)]
        public virtual DateTime CreatedOn { get; set; }
        [ScaffoldColumn(false)]
        public virtual long CreatedBy { get; set; }
        [ScaffoldColumn(false)]
        public virtual DateTime ModifiedOn { get; set; }
        [ScaffoldColumn(false)]
        public virtual long ModifiedBy { get; set; }
    }
}
