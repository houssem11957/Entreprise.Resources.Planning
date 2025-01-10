using DataAccess.Entities.Security;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Person
{
    [Table("ERP_BankingInformations_Table")]
    public  class BankingInformationsEntity : BaseEntity
    {
        public BankingInformationsEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int BankingInformations_Id { get; set; }
        public string BankAccountNumber { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public string AccountIssuer { get; set; }
        public int UserId { get; set; }
        public UserEntity User{ get; set; }
    }
}
