using DataAccess.Entities.Attendance;
using DataAccess.Entities.Person;
using DataAccess.Entities.Settings.BaseEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities.Security
{
	public class UserEntity: Microsoft.AspNetCore.Identity.IdentityUser<int>
	{
		public UserEntity()
		{
		}
		[Key]
		[Required]
		[NotNull]
		public override int Id { get; set; }
		[NotMapped]
		public override string PhoneNumber { get; set; }
		public string FamilyName { get; set; }
		public string FirstName { get; set; }
		public DateTime BirthDate { get; set; }
		public string NationalId { get; set; }
		public string TaxIdentificationNumber { get; set; }
		public string PasseportId { get; set; }
		public PersonContactInformationsEntity PersonContactInformations { get; set; }
		public ICollection<BankingInformationsEntity> BankingInformations { get; set; }
		public ICollection<SanctionsEntity> Sanctions { get; set; }
		public ICollection<EmployeeEvaluationEntity> EmployeeEvaluation { get; set; }
		public UserCompanyProfileEntity UserCompanyProfil { get; set; }
		public BiomitricInformationsEntity BiomitricInformations { get; set; }
		public ICollection<PointageEntity> Pointages { get; set; }

	}
}
