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
    public class WorkingTimeScheduleEntity : BaseEntity
    {
        public WorkingTimeScheduleEntity()
        {
            this.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int ScheduleId { get; set; } // Primary Key
        public DateTime EffectiveDate { get; set; } // Date when the schedule becomes effective
        public int? EndDay { get; set; } // End date if the schedule is temporary (nullable)
        public int? StartDay { get; set; } // End date if the schedule is temporary (nullable)
        public TimeSpan StartTime { get; set; } // Daily start time of the shift
        public TimeSpan EndTime { get; set; } // Daily end time of the shift
        public TimeSpan BreakDuration { get; set; } // Total break time during the shift
        public int TotalWorkingHours { get; set; } // Total working hours excluding breaks
        public int WorkDays { get; set; } 
        public string ShiftType { get; set; } // Shift type (e.g., "Morning", "Evening", "Night")
        public string Comments { get; set; } // Additional remarks or notes
        public UserCompanyProfileEntity Profile { get; set; }
        public int UserCompanyProfilId { get; set; }
        public override void InitValues()
        {
            EffectiveDate = DateTime.Now;
            WorkDays = 5;
            StartDay = 1;
            EndDay = WorkDays + StartDay;
            base.InitValues();
        }
    }
}
