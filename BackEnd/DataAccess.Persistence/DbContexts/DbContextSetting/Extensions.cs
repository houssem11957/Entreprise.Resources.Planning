using DataAccess.Entities.Attendance;
using DataAccess.Entities.Person;
using DataAccess.Entities.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Persistence.DbContexts.DbContextSetting
{
	public  static  class Extensions
	{
		public static void ApplyUserTableConfigurations(this ModelBuilder modelBuilder)
		{


			// banking informations

			modelBuilder.Entity<UserEntity>().HasKey(u => u.Id);
			modelBuilder.Entity<IdentityUserClaim<int>>().HasKey(c => c.Id);
			modelBuilder.Entity<IdentityUserRole<int>>().HasKey(ur => new { ur.UserId, ur.RoleId });
			modelBuilder.Entity<IdentityUserLogin<int>>().HasKey(l => l.UserId);
			modelBuilder.Entity<IdentityRoleClaim<int>>().HasKey(rc => rc.Id);
			modelBuilder.Entity<IdentityUserToken<int>>().HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
			
			modelBuilder.Entity<BankingInformationsEntity>(bankingentity =>
			{
				bankingentity.HasOne(x => x.User)
				.WithMany(u => u.BankingInformations)
				.HasForeignKey(u => u.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			}); 
			// Biomitric Informations
			modelBuilder.Entity<BiomitricInformationsEntity>(
				biotmetricInformations =>
				{
					biotmetricInformations
					.HasOne(d => d.User)
					.WithOne(x => x.BiomitricInformations)
					.HasForeignKey<BiomitricInformationsEntity>(c => c.UserId)
					.OnDelete(DeleteBehavior.Cascade)
					;
				}
				);

			modelBuilder.Entity<EmployeeEvaluationEntity>(EmployeeEvaluation =>
			{

				EmployeeEvaluation.HasOne(x => x.User)
				.WithMany(u => u.EmployeeEvaluation)
				.HasForeignKey(f => f.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			//Person Contact Informations
			modelBuilder.Entity<PersonContactInformationsEntity>(personContact =>
			{
				personContact.HasOne(p => p.UserEntity)
				.WithOne(u => u.PersonContactInformations)
				.HasForeignKey<PersonContactInformationsEntity>(pe => pe.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity<SanctionsEntity>(sanctionEntity =>
			{
				sanctionEntity.HasOne(s => s.user)
				.WithMany(u => u.Sanctions)
				.HasForeignKey(el => el.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity<PointageEntity>(
				p =>
				{
					p.HasOne(u => u.user)
					.WithMany(po => po.Pointages)
					.HasForeignKey(o => o.UserId)
					.OnDelete(DeleteBehavior.Cascade);
				}
				);

			/*modelBuilder.Entity<ErpUserRole>(userRole =>
			{
				//add composed primary key (user id ,role id)
				userRole.HasKey(ur => new { ur.Id, ur.RoleId });

				userRole.HasOne(ur => ur.User)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.Id)
					.IsRequired();
			});*/
		}
	}
}
