using DataAccess.Entities.Person;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.PayRoll
{
    public class PublicHolidaysEntity : BaseEntity
    {
        public PublicHolidaysEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int PublicHolidaysId { get; set; } // Unique identifier for the holiday
        public string Name { get; set; } // Name of the public holiday
        public DateTime StartDate { get; set; } // Start date of the holiday
        public DateTime EndDate { get; set; } // End date of the holiday
        public string Country { get; set; } // Country where the holiday is observed
        public string Region { get; set; } // Specific region, if applicable
        public bool IsPublicHoliday { get; set; } // True if it is a public holiday
        public bool IsRecurring { get; set; } // True if it recurs annually (e.g., Christmas)
        public string Notes { get; set; } // Additional notes about the holiday
        public ICollection<UserCompanyProfileEntity> Profiles { get; set; } // Users linked to this public holiday
        [NotMapped]
        public int DurationInDays => (EndDate - StartDate).Days + 1;
    }
}
