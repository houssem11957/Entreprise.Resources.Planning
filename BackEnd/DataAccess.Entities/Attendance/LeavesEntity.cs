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
    public class LeavesEntity : BaseEntity
    {
        public LeavesEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int LeaveId { get; set; } 
        public DateTime StartDate { get; set; } // Leave start date
        public DateTime EndDate { get; set; } // Leave end date
        public int TotalDays { get; set; } // Total number of leave days
        public string LeaveType { get; set; } // Type of leave (e.g., "Sick", "Vacation", "Casual")
        public string Reason { get; set; } // Reason for the leave
        public string Status { get; set; } // Status of the leave (e.g., "Pending", "Approved", "Rejected")
        public DateTime? ApprovedAt { get; set; } // Timestamp when leave was approved
        public string ApprovedBy { get; set; } // User/Manager who approved the leave
        public DateTime? RejectedAt { get; set; } // Timestamp when leave was rejected
        public string RejectedBy { get; set; } // User/Manager who rejected the leave
        public string Comments { get; set; } // Additional comments or notes
        public UserCompanyProfileEntity Profile { get; set; }
        public int UserCompanyProfilId { get; set; }
    }
}
