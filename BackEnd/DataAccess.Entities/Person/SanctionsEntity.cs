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
    [Table("ERP_Sanctions_Table")]
    public class SanctionsEntity : BaseEntity
    {
        public SanctionsEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int SanctionsId { get; set; }
        public string Type { get; set; }
        public int NumberOfdays { get; set; }
        public string Reason { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Cancelled { get; set; }
        public UserEntity user { get; set; }
        public int UserId { get; set; }
    }
}
