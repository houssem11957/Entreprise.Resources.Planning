using DataAccess.Entities.Attendance;
using DataAccess.Entities.PayRoll;
using DataAccess.Entities.Person;
using DataAccess.Entities.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence.ApplicationDbContext
{
	public class ERPDbContext: IdentityDbContext<UserEntity, ErpRole, int,
										IdentityUserClaim<int>, ErpUserRole,
										IdentityUserLogin<int>, IdentityRoleClaim<int>,
										IdentityUserToken<int>>

	{
		public ERPDbContext(DbContextOptions<ERPDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Tables relationship definition
			// banking informations
			modelBuilder.Entity<BankingInformationsEntity>(bankingentity =>
			{
				bankingentity.HasOne(x => x.User)
				.WithMany(u => u.BankingInformations)
				.HasForeignKey(u => u.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			});
			// Biomitric Informations
			modelBuilder.Entity<BiomitricInformationsEntity>(
				biomitrcrinformation =>
				{
					biomitrcrinformation
					.HasOne(d => d.User)
					.WithOne(x => x.BiomitricInformations)
					.HasForeignKey<BiomitricInformationsEntity>(c => c.UserId)
					.OnDelete(DeleteBehavior.Cascade);
				}
				);

			// EmployEEeVALUATION
			modelBuilder.Entity<EmployeeEvaluationEntity>().Property(x => x.AttendanceScore).HasColumnType("decimal").HasPrecision(10, 4).HasDefaultValue(20.00);
			modelBuilder.Entity<EmployeeEvaluationEntity>().Property(x => x.PerformanceScore).HasColumnType("decimal").HasPrecision(10, 4).HasDefaultValue(100.00);
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
			modelBuilder.Entity<UserCompanyProfileEntity>(userCompany =>
			{
				userCompany.HasOne(u => u.User)
				.WithOne(uc => uc.UserCompanyProfil)
				.HasForeignKey<UserCompanyProfileEntity>(fk => fk.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			// pointage 
			modelBuilder.Entity<PointageEntity>(
				p =>
				{
					p.HasOne(u => u.user)
					.WithMany(po => po.Pointages)
					.HasForeignKey(o => o.UserId)
					.OnDelete(DeleteBehavior.Cascade);
				}
				);
			// working time schedule
			modelBuilder.Entity<WorkingTimeScheduleEntity>(wts =>
			{
				wts.HasOne(u => u.Profile)
				.WithMany(x => x.WorkingTimeSchedules)
				.HasForeignKey(f => f.UserCompanyProfilId)
				.OnDelete(DeleteBehavior.Cascade);
			});
			// Leaves
			modelBuilder.Entity<LeavesEntity>(l =>
			{
				l.HasOne(x => x.Profile)
				.WithMany(x => x.Leaves)
				.HasForeignKey(x => x.UserCompanyProfilId)
				.OnDelete(DeleteBehavior.Cascade);
			});
			base.OnModelCreating(modelBuilder);

			// Employee Category
			modelBuilder.Entity<EmployeeCategoryEntity>(ec =>
			{
				ec.HasOne(x => x.UserProfile)
				.WithMany(y => y.EmployeeCategories)
				.HasForeignKey(fk => fk.UserProfileId)
				.OnDelete(DeleteBehavior.Cascade);
			});


			modelBuilder.Entity<DataAccess.Entities.CommunEntities.UserPublicHolidayEntity>(entity =>
			{
				//entity.HasKey(e => e.UserPublicHolidayId);

				entity.HasOne(e => e.Profile)
					.WithMany()
					.HasForeignKey(e => e.UserCompanyProfilId)
					.OnDelete(DeleteBehavior.Cascade);

				entity.HasOne(e => e.PublicHoliday)
					.WithMany()
					.HasForeignKey(e => e.PublicHolidaysId)
					.OnDelete(DeleteBehavior.Cascade);
			});

			modelBuilder.Entity<ErpUserRole>(userRole =>
			{
				//add composed primary key (user id ,role id)
				userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

				userRole.HasOne(ur => ur.Role)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.RoleId)
					.IsRequired();

				userRole.HasOne(ur => ur.User)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.UserId)
					.IsRequired();
			});
			#endregion
		}
		#region Tables definitions
		DbSet<BankingInformationsEntity> BankingInformations { get; set; }
		DbSet<BiomitricInformationsEntity> BiomitricInformations { get; set; }
		DbSet<EmployeeEvaluationEntity> EmployeeEvaluations { get; set; }
		DbSet<PersonContactInformationsEntity> PersonContactInformations { get; set; }
		DbSet<SanctionsEntity> Sanctions { get; set; }
		DbSet<UserCompanyProfileEntity> UserCompanyProfiles { get; set; }
		DbSet<UserEntity> Users { get; set; }
		DbSet<PointageEntity> Pointages { get; set; }
		DbSet<WorkingTimeScheduleEntity> WorkingTimeSchedules { get; set; }
		DbSet<LeavesEntity> Leaves { get; set; }
		DbSet<EmployeeCategoryEntity> EmployeeCategories { get; set; }
		DbSet<PublicHolidaysEntity> PublicHolidays { get; set; }
		DbSet<DataAccess.Entities.CommunEntities.UserPublicHolidayEntity> UserPublicHoliday { get; set; }
		#endregion
	}
}
