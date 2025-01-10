using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.PayRoll
{
    public  class allowancesBenefitsRatesEntity : BaseEntity
    {
        public allowancesBenefitsRatesEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int allowancesBenefitsRatesId { get; set; } // Unique identifier for the rate
        public string Identifier { get; set; } 
        public string AllowanceName { get; set; } // Name of the allowance or benefit
        public decimal Rate { get; set; } // Rate or amount of the allowance/benefit
        public string RateType { get; set; } // Type of rate (e.g., Percentage, Fixed)
        public string Frequency { get; set; } // Frequency (e.g., Monthly, Weekly, Annually)
        public string EmployeeCategory { get; set; } // Category of employees eligible
        public DateTime EffectiveFrom { get; set; } // Start date for the rate
        public DateTime EffectiveTo { get; set; } // End date for the rate (optional, for expiry)
        public string Notes { get; set; } // Additional notes or description
        public bool IsTaxable { get; set; } // Indicates if the allowance/benefit is taxable
        public decimal TaxRate { get; set; } // Indicates if the allowance/benefit is taxable
        public string Currency { get; set; } // Currency of the rate
        public bool IsActive { get; set; } // Currency of the rate
    }
}
