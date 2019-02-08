using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Bl.Results
{
    public class ActionResult<T>
    {
        public T Result { get; set; }   
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
