using DataAccess.Entities.Security;
using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Person
{
    public  class BiomitricInformationsEntity : BaseEntity
    {
        public BiomitricInformationsEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int BiomitricInformationsId { get; set; }
        public string RegistrationNumber { get; set; }
        public byte[] FingerprintData { get; set; } 
        public byte[] FacialRecognitionData { get; set; } 
        public byte[] RetinaScanData { get; set; } 
        public DateTime EnrollmentDate { get; set; } 
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; } 
    }
}
