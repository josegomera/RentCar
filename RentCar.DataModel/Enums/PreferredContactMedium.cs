using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Enums
{
    public enum PreferredContactMedium : int
    {
        [Description("Teléfono")]
        Phone,
        [Description("Correo electrónico")]
        Email
    }
}
