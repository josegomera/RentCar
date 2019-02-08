using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Enums
{
    public enum DocumentType : int
    {
        [Description("Cédula")]
        IdentificationCard,
        [Description("Pasaporte")]
        Passport,
        [Description("Licencia de conducir")]
        DriverLicense
    }
}
