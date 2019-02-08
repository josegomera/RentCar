using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Enums
{
    public enum RubberState : int
    {
        [Description("Buena")]
        Good,
        [Description("Pinchada")]
        Punctured,
        [Description("Desgastada")]
        Worn,
        [Description("Inservible")]
        Useless,
    }
}
