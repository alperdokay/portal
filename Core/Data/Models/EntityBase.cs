using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Models
{
    public class EntityBase
    {
        [Key]
        [ScaffoldColumn(false)]
        public virtual long Id { get; set; }
    }
}
