using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Enums
{
    public enum FuelAmount : int
    {
        [Description("Un cuarto (1/4)")]
        Quarter,
        [Description("Medio (1/2)")]
        Half,
        [Description("Tres cuartos (3/4)")]
        ThreeQuarters,
        [Description("Lleno")]
        Full
    }
}
