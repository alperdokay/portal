using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Models
{
    public class DeletableEntityBase : EntityBase
    {
        [ScaffoldColumn(false)]
        public virtual bool IsDeleted { get; set; }
    }
}
