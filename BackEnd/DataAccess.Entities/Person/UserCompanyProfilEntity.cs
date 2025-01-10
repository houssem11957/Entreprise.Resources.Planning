using DataAccess.Entities.Attendance;
using DataAccess.Entities.PayRoll;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Person
{
    public class UserCompanyProfileEntity : BaseEntity
    {
        public UserCompanyProfileEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int UserCompanyProfilId { get; set; }
        public int EmployeeId { get; set; }
        public string HealthInsuranceNumber { get; set; }
        public UserEntity User { get; set; }
        public int UserId { get; set; }
        public ICollection<LeavesEntity> Leaves { get; set; }
        public ICollection<WorkingTimeScheduleEntity> WorkingTimeSchedules { get; set; }
        public ICollection<EmployeeCategoryEntity> EmployeeCategories { get; set; }
        public ICollection<PublicHolidaysEntity> PublicHolidays { get; set; } // Holidays linked to the user

    }
}
