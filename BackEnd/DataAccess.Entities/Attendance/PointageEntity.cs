using DataAccess.Entities.Person;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Attendance
{
    public class PointageEntity : BaseEntity
    {
        public PointageEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int PointageId { get; set; } 
        public DateTime ClockIn { get; set; }
        public DateTime? ClockOut { get; set; } 
        public int? TotalHours { get; set; } 
        public string Status { get; set; } // E.g., "Present", "Late", "Absent"
        public string Comments { get; set; }
        public UserEntity user { get; set; }
        public int UserId { get; set; }

    }
}
