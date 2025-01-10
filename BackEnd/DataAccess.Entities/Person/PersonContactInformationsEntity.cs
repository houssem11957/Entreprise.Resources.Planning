using DataAccess.Entities.Security;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Person
{
    public  class PersonContactInformationsEntity : BaseEntity
    {
        public PersonContactInformationsEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int PersonContactInformations_Id { get; set; }
        [Required]
        public string Email { get; set; }
        public  string PhoneNumber { get; set; }
        public  string Address { get; set; }
        public  int City { get; set; }
        public  int Country { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public UserEntity UserEntity { get; set; }
        public int UserId { get; set; }

    }
}
