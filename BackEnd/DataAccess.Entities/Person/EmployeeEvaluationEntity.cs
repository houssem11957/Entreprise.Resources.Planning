using DataAccess.Entities.Security;
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
    public  class EmployeeEvaluationEntity : BaseEntity
    {
        public EmployeeEvaluationEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int EmployeeEvaluationId { get; set; }
        public int EmployeeId { get; set; } 
        public int Year { get; set; } 
        public int Month { get; set; } 
        public decimal AttendanceScore { get; set; } 
        public decimal PerformanceScore { get; set; } 
        public string? Comments { get; set; } 
        public bool IsActive { get; set; } = true;
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
