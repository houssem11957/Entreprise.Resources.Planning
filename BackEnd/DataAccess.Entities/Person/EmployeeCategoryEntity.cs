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
    public  class EmployeeCategoryEntity : BaseEntity
    {
        public EmployeeCategoryEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int EmployeeCategoryId { get; set; }
        public string  Name { get; set; }
        public bool  IsMandatory { get; set; }
        public UserCompanyProfileEntity UserProfile { get; set; }
        public int UserProfileId { get; set; }
    }
}
