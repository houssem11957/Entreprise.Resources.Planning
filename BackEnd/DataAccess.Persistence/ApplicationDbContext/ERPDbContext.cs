using DataAccess.Entities.Attendance;
using DataAccess.Entities.CommunEntities;
using DataAccess.Entities.PayRoll;
using DataAccess.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Persistence.ApplicationDbContext
{
    public class ERPDbContext : DbContext
    {
        public ERPDbContext(DbContextOptions config) : base(config)
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


                                modelBuilder.Entity<PublicHolidaysEntity>(x => {
                x.HasMany(x => x.Profiles)
                 .WithMany(x => x.PublicHolidays);
                 
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
        #endregion
    }
}
