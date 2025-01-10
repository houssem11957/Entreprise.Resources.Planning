using DataAccess.Entities.Settings.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.PayRoll
{
    public class TaxesDeductionsRatesEntity : BaseEntity
    {
        public TaxesDeductionsRatesEntity()
        {
            base.InitValues();
        }
        [Key]
        [Required]
        [NotNull]
        public int TaxesDeductionsRatesId { get; set; } // Unique identifier for the deduction
        public int EmployeeCategoryId { get; set; } // Employee category applicable for the deduction
        private protected string DeductionName { get; set; } // Name of the deduction (e.g., tax, insurance)
        public decimal Rate { get; set; } // Rate or amount of the deduction
        public string RateType { get; set; } // Type of rate (e.g., Percentage, Fixed)
        public string Frequency { get; set; } // Frequency of the deduction (e.g., Monthly, Annually)
        public DateTime EffectiveFrom { get; set; } // Start date for the deduction
        public DateTime EffectiveTo { get; set; } // End date for the deduction (optional)
        internal bool IsMandatory { get; set; } // Indicates if the deduction is mandatory
        public string Currency { get; set; } // Currency for the deduction rate
        public string Notes { get; set; } // Additional notes about the deduction
    }
}
