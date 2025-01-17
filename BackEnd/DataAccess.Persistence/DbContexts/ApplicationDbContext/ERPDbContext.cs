using DataAccess.Entities.Attendance;
using DataAccess.Entities.PayRoll;
using DataAccess.Entities.Person;
using DataAccess.Entities.Security;
using DataAccess.Persistence.DbContexts.DbContextSetting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence.DbContexts.ApplicationDbContext
{
	public class ERPDbContext: DbContext
	{
		public ERPDbContext(DbContextOptions<ERPDbContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Tables relationship definition

			// config user table
			base.OnModelCreating(modelBuilder);
			
			
			modelBuilder.ApplyUserTableConfigurations();

			// EmployEEeVALUATION
			modelBuilder.Entity<EmployeeEvaluationEntity>().Property(x => x.AttendanceScore).HasColumnType("decimal").HasPrecision(10, 4).HasDefaultValue(20.00);
			modelBuilder.Entity<EmployeeEvaluationEntity>().Property(x => x.PerformanceScore).HasColumnType("decimal").HasPrecision(10, 4).HasDefaultValue(100.00);
			
			modelBuilder.Entity<UserCompanyProfileEntity>(userCompany =>
			{
				userCompany.HasOne(u => u.User)
				.WithOne(uc => uc.UserCompanyProfil)
				.HasForeignKey<UserCompanyProfileEntity>(fk => fk.UserId)
				.OnDelete(DeleteBehavior.Cascade);
			});

			// pointage 
			
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


			modelBuilder.Entity<Entities.CommunEntities.UserPublicHolidayEntity>(entity =>
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

			
			#endregion
		}
		#region Tables definitions
		//DbSet<BankingInformationsEntity> BankingInformations { get; set; }
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
		DbSet<Entities.CommunEntities.UserPublicHolidayEntity> UserPublicHoliday { get; set; }
		#endregion
	}
}
