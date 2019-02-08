using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Entities.Base
{
    public interface IAuditEntityBase : IEntityBase
    {
        DateTimeOffset CreatedDate { get; set; }
        DateTimeOffset? ModifiedDate { get; set; }
        int CreatedBy { get; set; }
        int? ModifiedBy { get; set; }
        bool IsDisabled { get; set; }
    }
}
