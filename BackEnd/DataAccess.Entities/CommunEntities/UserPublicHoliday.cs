using DataAccess.Entities.PayRoll;
using DataAccess.Entities.Person;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.CommunEntities
{
    public  class UserPublicHolidayEntity:BaseEntity
    {
        public UserPublicHolidayEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int UserPublicHolidayId { get; set; }
        public int UserCompanyProfilId { get; set; }
        public UserCompanyProfileEntity profile { get; set; }
        public int PublicHolidaysId { get; set; }
        public PublicHolidaysEntity PublicHoliday { get; set; }
    }
}
