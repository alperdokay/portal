using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRC.Portal.Common.Enums;

namespace FRC.Portal.Services.Models
{
    public class DashboardUserViewModel
    {
        public string full_name { get; set; }
        public string image_path { get; set; }
        public EnumAccountTypes.Roles user_role { get; set; }
    }
}
