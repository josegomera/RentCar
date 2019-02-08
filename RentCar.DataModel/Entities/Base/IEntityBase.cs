using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Entities.Base
{
    public interface IEntityBase
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }    
    }
}
