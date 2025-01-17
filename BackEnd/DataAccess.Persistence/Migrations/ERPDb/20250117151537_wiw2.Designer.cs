﻿// <auto-generated />
using System;
using DataAccess.Persistence.DbContexts.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Persistence.Migrations.ERPDb
{
    [DbContext(typeof(ERPDbContext))]
    [Migration("20250117151537_wiw2")]
    partial class wiw2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entities.Attendance.LeavesEntity", b =>
                {
                    b.Property<int>("LeaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveId"));

                    b.Property<DateTime?>("ApprovedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApprovedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("LeaveType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RejectedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("RejectedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalDays")
                        .HasColumnType("int");

                    b.Property<int>("UserCompanyProfilId")
                        .HasColumnType("int");

                    b.HasKey("LeaveId");

                    b.HasIndex("UserCompanyProfilId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("DataAccess.Entities.Attendance.PointageEntity", b =>
                {
                    b.Property<int>("PointageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PointageId"));

                    b.Property<DateTime>("ClockIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ClockOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TotalHours")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PointageId");

                    b.HasIndex("UserId");

                    b.ToTable("Pointages");
                });

            modelBuilder.Entity("DataAccess.Entities.Attendance.WorkingTimeScheduleEntity", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"));

                    b.Property<TimeSpan>("BreakDuration")
                        .HasColumnType("time");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EndDay")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("ShiftType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StartDay")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("TotalWorkingHours")
                        .HasColumnType("int");

                    b.Property<int>("UserCompanyProfilId")
                        .HasColumnType("int");

                    b.Property<int>("WorkDays")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("UserCompanyProfilId");

                    b.ToTable("WorkingTimeSchedules");
                });

            modelBuilder.Entity("DataAccess.Entities.CommunEntities.UserPublicHolidayEntity", b =>
                {
                    b.Property<int>("UserPublicHolidayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPublicHolidayId"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("PublicHolidaysId")
                        .HasColumnType("int");

                    b.Property<int>("UserCompanyProfilId")
                        .HasColumnType("int");

                    b.HasKey("UserPublicHolidayId");

                    b.HasIndex("PublicHolidaysId");

                    b.HasIndex("UserCompanyProfilId");

                    b.ToTable("UserPublicHoliday");
                });

            modelBuilder.Entity("DataAccess.Entities.PayRoll.PublicHolidaysEntity", b =>
                {
                    b.Property<int>("PublicHolidaysId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublicHolidaysId"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPublicHoliday")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecurring")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PublicHolidaysId");

                    b.ToTable("PublicHolidays");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.BankingInformationsEntity", b =>
                {
                    b.Property<int>("BankingInformations_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BankingInformations_Id"));

                    b.Property<string>("AccountIssuer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("ExpiryDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BankingInformations_Id");

                    b.HasIndex("UserId");

                    b.ToTable("ERP_BankingInformations_Table");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.BiomitricInformationsEntity", b =>
                {
                    b.Property<int>("BiomitricInformationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BiomitricInformationsId"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FacialRecognitionData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("FingerprintData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RetinaScanData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BiomitricInformationsId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("BiomitricInformations");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.EmployeeCategoryEntity", b =>
                {
                    b.Property<int>("EmployeeCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeCategoryId"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMandatory")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeCategoryId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("EmployeeCategories");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.EmployeeEvaluationEntity", b =>
                {
                    b.Property<int>("EmployeeEvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeEvaluationId"));

                    b.Property<decimal>("AttendanceScore")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal")
                        .HasDefaultValue(20m);

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<decimal>("PerformanceScore")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal")
                        .HasDefaultValue(100m);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("EmployeeEvaluationId");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeEvaluations");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.PersonContactInformationsEntity", b =>
                {
                    b.Property<int>("PersonContactInformations_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonContactInformations_Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmergencyContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PersonContactInformations_Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("PersonContactInformations");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.SanctionsEntity", b =>
                {
                    b.Property<int>("SanctionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SanctionsId"));

                    b.Property<bool>("Cancelled")
                        .HasColumnType("bit");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfdays")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SanctionsId");

                    b.HasIndex("UserId");

                    b.ToTable("ERP_Sanctions_Table");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.UserCompanyProfileEntity", b =>
                {
                    b.Property<int>("UserCompanyProfilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserCompanyProfilId"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("HealthInsuranceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserCompanyProfilId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserCompanyProfiles");
                });

            modelBuilder.Entity("DataAccess.Entities.Security.ErpUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("ErpUserRole");
                });

            modelBuilder.Entity("DataAccess.Entities.Security.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasseportId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxIdentificationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IdentityRoleClaim<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IdentityUserClaim<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("IdentityUserLogin<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("IdentityUserToken<int>");
                });

            modelBuilder.Entity("PublicHolidaysEntityUserCompanyProfileEntity", b =>
                {
                    b.Property<int>("ProfilesUserCompanyProfilId")
                        .HasColumnType("int");

                    b.Property<int>("PublicHolidaysId")
                        .HasColumnType("int");

                    b.HasKey("ProfilesUserCompanyProfilId", "PublicHolidaysId");

                    b.HasIndex("PublicHolidaysId");

                    b.ToTable("PublicHolidaysEntityUserCompanyProfileEntity");
                });

            modelBuilder.Entity("DataAccess.Entities.Attendance.LeavesEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Person.UserCompanyProfileEntity", "Profile")
                        .WithMany("Leaves")
                        .HasForeignKey("UserCompanyProfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("DataAccess.Entities.Attendance.PointageEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "user")
                        .WithMany("Pointages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DataAccess.Entities.Attendance.WorkingTimeScheduleEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Person.UserCompanyProfileEntity", "Profile")
                        .WithMany("WorkingTimeSchedules")
                        .HasForeignKey("UserCompanyProfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("DataAccess.Entities.CommunEntities.UserPublicHolidayEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.PayRoll.PublicHolidaysEntity", "PublicHoliday")
                        .WithMany()
                        .HasForeignKey("PublicHolidaysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Person.UserCompanyProfileEntity", "Profile")
                        .WithMany()
                        .HasForeignKey("UserCompanyProfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");

                    b.Navigation("PublicHoliday");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.BankingInformationsEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "User")
                        .WithMany("BankingInformations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.BiomitricInformationsEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "User")
                        .WithOne("BiomitricInformations")
                        .HasForeignKey("DataAccess.Entities.Person.BiomitricInformationsEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.EmployeeCategoryEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Person.UserCompanyProfileEntity", "UserProfile")
                        .WithMany("EmployeeCategories")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.EmployeeEvaluationEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "User")
                        .WithMany("EmployeeEvaluation")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.PersonContactInformationsEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "UserEntity")
                        .WithOne("PersonContactInformations")
                        .HasForeignKey("DataAccess.Entities.Person.PersonContactInformationsEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.SanctionsEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "user")
                        .WithMany("Sanctions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DataAccess.Entities.Person.UserCompanyProfileEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", "User")
                        .WithOne("UserCompanyProfil")
                        .HasForeignKey("DataAccess.Entities.Person.UserCompanyProfileEntity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Entities.Security.ErpUserRole", b =>
                {
                    b.HasOne("DataAccess.Entities.Security.UserEntity", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("PublicHolidaysEntityUserCompanyProfileEntity", b =>
                {
                    b.HasOne("DataAccess.Entities.Person.UserCompanyProfileEntity", null)
                        .WithMany()
                        .HasForeignKey("ProfilesUserCompanyProfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.PayRoll.PublicHolidaysEntity", null)
                        .WithMany()
                        .HasForeignKey("PublicHolidaysId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Entities.Person.UserCompanyProfileEntity", b =>
                {
                    b.Navigation("EmployeeCategories");

                    b.Navigation("Leaves");

                    b.Navigation("WorkingTimeSchedules");
                });

            modelBuilder.Entity("DataAccess.Entities.Security.UserEntity", b =>
                {
                    b.Navigation("BankingInformations");

                    b.Navigation("BiomitricInformations")
                        .IsRequired();

                    b.Navigation("EmployeeEvaluation");

                    b.Navigation("PersonContactInformations")
                        .IsRequired();

                    b.Navigation("Pointages");

                    b.Navigation("Sanctions");

                    b.Navigation("UserCompanyProfil")
                        .IsRequired();

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
