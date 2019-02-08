using RentCar.DataModel.Entities.Base;
using RentCar.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.DataModel.Entities
{
    public class Inspection : IAuditEntityBase
    {
        [Key, Display(AutoGenerateField = false)]
        [Column("InspectionId")]
        [CustomRequired]
        public int Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Vehículo")]
        public int VehicleId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Cliente")]
        public int ClientId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "El campo {0} es requirido.")]
        [CustomRequired]
        [Display(Name = "Empleado")]
        public int EmployeeId { get; set; }
        [EnumDataType(typeof(FuelAmount))]
        [CustomRequired]
        [Display(Name = "Cantidad combustible")]
        public FuelAmount FuelAmount { get; set; }
        [CustomRequired]
        [Display(Name = "Tiene ralladuras")]
        public bool HasScratches { get; set; }
        [CustomRequired]
        [Display(Name = "Tiene goma respuesta")]
        public bool HasAnswerRubber { get; set; }
        [CustomRequired]
        [Display(Name = "Tiene Gato")]
        public bool HasHydraulicJack { get; set; }
        [CustomRequired]
        [Display(Name = "Tiene roturas cristal")]
        public bool HasGlassBreakage { get; set; }
        [EnumDataType(typeof(RubberState))]
        [CustomRequired]
        [Display(Name = "Estado goma delantera derecha")]
        public RubberState RubberFrontRight { get; set; }
        [EnumDataType(typeof(RubberState))]
        [CustomRequired]
        [Display(Name = "Estado goma delantera izquierda")]
        public RubberState RubberFrontLeft { get; set; }
        [EnumDataType(typeof(RubberState))]
        [CustomRequired]
        [Display(Name = "Estado goma trasera derecha")]
        public RubberState RubberBottomRight { get; set; }
        [EnumDataType(typeof(RubberState))]
        [CustomRequired]
        [Display(Name = "Estado goma trasera izquierda")]
        public RubberState RubberBottomLeft { get; set; }
        [DataType(DataType.Date)]
        [CustomRequired]
        [Display(Name = "Fecha de inspección")]
        public DateTime InspectionDate { get; set; }
        /// <summary>
        /// Bool property represent if the Inspection was deleted
        /// </summary>
        [Display(AutoGenerateField = false)]
        public bool IsDeleted { get; set; }
        public Vehicle Vehicle { get; set; }    
        public Client  Client { get; set; }
        public Employee Employee { get; set; }


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
