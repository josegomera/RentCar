using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Enums
{
    public enum WorkShift : int
    {
        [Description("Matutino")]
        Morning,
        [Description("Vespertino")]
        Evening,
        [Description("Nocturno")]
        Night
    }
}
