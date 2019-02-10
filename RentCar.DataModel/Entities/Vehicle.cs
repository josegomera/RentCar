using RentCar.DataModel.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Entities
{
    public class Vehicle : IAuditEntityBase
    {
        [Key, Display(AutoGenerateField = false)]
        [Column("VehicleId")]
        [CustomRequired]
        public int Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Tipo")]
        public int VehicleTypeId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Marca")]
        public int VehicleBrandId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Modelo")]
        public int VehicleModelId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Combustible")]
        public int FuelTypeId { get; set; } 
        [CustomRequired]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [CustomRequired]
        [Display(Name = "Número de chasis")]
        public string ChasisNumber { get; set; }
        [CustomRequired]
        [Display(Name = "Número de motor")]
        public string MotorNumber { get; set; }
        [CustomRequired]
        [Display(Name = "Número de placa")]
        public string PlacaNumber { get; set; } 
        public VehicleType VehicleType { get; set; }
        public VehicleBrand VehicleBrand { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public FuelType FuelType { get; set; }
        /// <summary>
        /// Bool property represent if the Vehicle was deleted
        /// </summary>
        [Display(AutoGenerateField = false)]
        public bool IsDeleted { get; set; }
     

        #region AuditFields
        /// <summary>
        /// Date property representing the date on which the entity was created
        /// </summary>
        [Display(AutoGenerateField = false)]
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Date property representing the date on which the entity was edited
        /// </summary>
        [Display(AutoGenerateField = false)]
        public DateTimeOffset? ModifiedDate { get; set; }

        /// <summary>
        /// Guid property representing the user who created the entity
        /// </summary>
        [Display(AutoGenerateField = false)]
        public int CreatedBy { get; set; }

        /// <summary>
        /// Guid property representing the user who edited the entity
        /// </summary>
        [Display(AutoGenerateField = false)]
        public int? ModifiedBy { get; set; }

        /// <summary>
        /// bool property represent if the cut was disabled
        /// </summary>
        [Display(Name = "¿Esta desahabilitado?")]
        public bool IsDisabled { get; set; }
        #endregion
    }
}
