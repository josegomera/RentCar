using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel
{
    public class CustomRequired : RequiredAttribute
    {
        public CustomRequired()
        {
            this.ErrorMessage = "El campo {0} es requerido.";
        }
    }
}
