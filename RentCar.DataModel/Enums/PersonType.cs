using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Enums
{
    public enum PersonType : int
    {
        [Description("Física")]
        Physical,
        [Description("Jurídica")]
        Legal
    }
}
