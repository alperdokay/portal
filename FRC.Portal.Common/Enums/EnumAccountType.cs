using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRC.Portal.Common.Enums
{
    public enum EnumAccountType : int
    {
        [Description("Admin")]
        Admin = 10,
        [Description("Komite üyesi")]
        Committee = 20,
        [Description("Takım")]
        Team = 30,
        [Description("Gönüllü")]
        Volunteer = 40,
        [Description("Mezun")]
        Alumni = 50
    }
}
