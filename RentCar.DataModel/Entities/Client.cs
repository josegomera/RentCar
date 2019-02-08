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
    public class Client : IAuditEntityBase
    {
        public Client()
        {
        }
        [Key, Display(AutoGenerateField = false)]
        [Column("ClientId")]
        [CustomRequired]
        public int Id { get; set; }
        [CustomRequired]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [Phone]
        [Display(Name = "Teléfono")]
        public string Phone { get; set; }
        [EmailAddress(ErrorMessage = "El campo {0} no contiene un correo válido.")]
        [CustomRequired]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        [EnumDataType(typeof(DocumentType))]
        [CustomRequired]
        [Display(Name = "Tipo de documento")]
        public DocumentType DocumentType { get; set; }
        [CustomRequired]
        [Display(Name = "Documento")]
        public string Document { get; set; }
        [CreditCard]
        [Display(Name = "Tarjeta de crédito")]
        public string CreditCardNumber { get; set; }
        [DataType(DataType.Currency)]
        [CustomRequired]
        [Display(Name = "Límite de crédito")]
        public int CreditLimit { get; set; }
        [EnumDataType(typeof(PersonType))]
        [CustomRequired]
        [Display(Name = "Tipo de persona")]
        public PersonType PersonType { get; set; }
        /// <summary>
        /// Bool property represent if the Client was deleted
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
