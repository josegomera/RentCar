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
    public class Rent : IAuditEntityBase
    {
        [Key, Display(AutoGenerateField = false)]
        [Column("RentId")]
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
        [DataType(DataType.MultilineText)]
        [CustomRequired]
        [Display(Name = "Comentario")]
        public string Comment { get; set; }
        [DataType(DataType.Currency)]
        [CustomRequired]
        [Display(Name = "Monto por día")]
        public int AmountPerDay { get; set; }
        [NotMapped]
        [Display(Name = "Cantidad de días")]
        public int NumberOfDays {
           get {
                return (ReturnDate - RentDate).Days;
            }
        }
        [DataType(DataType.Date)]
        [CustomRequired]
        [Display(Name = "Fecha renta")]
        public DateTime RentDate { get; set; }
        [DataType(DataType.Date)]
        [CustomRequired]
        [Display(Name = "Fecha devolución")]
        public DateTime ReturnDate { get; set; }
        /// <summary>
        /// Bool property represent if the Rent was deleted
        /// </summary>
        [Display(AutoGenerateField = false)]
        public bool IsDeleted { get; set; }
        public Vehicle Vehicle { get; set; }
        public Client Client { get; set; }
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
