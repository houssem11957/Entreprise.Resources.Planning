using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class payrollSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeCategories",
                columns: table => new
                {
                    EmployeeCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    UserProfileId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCategories", x => x.EmployeeCategoryId);
                    table.ForeignKey(
                        name: "FK_EmployeeCategories_UserCompanyProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserCompanyProfiles",
                        principalColumn: "UserCompanyProfilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicHolidays",
                columns: table => new
                {
                    PublicHolidaysId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublicHoliday = table.Column<bool>(type: "bit", nullable: false),
                    IsRecurring = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidays", x => x.PublicHolidaysId);
                });

            migrationBuilder.CreateTable(
                name: "UserPublicHolidayEntity",
                columns: table => new
                {
                    UserPublicHolidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    profileUserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    PublicHolidaysId = table.Column<int>(type: "int", nullable: false),
                    PublicHolidaysId1 = table.Column<int>(type: "int", nullable: false),
                    ProfilesUserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPublicHolidayEntity", x => x.UserPublicHolidayId);
                    table.ForeignKey(
                        name: "FK_UserPublicHolidayEntity_PublicHolidays_PublicHolidaysId",
                        column: x => x.PublicHolidaysId,
                        principalTable: "PublicHolidays",
                        principalColumn: "PublicHolidaysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPublicHolidayEntity_PublicHolidays_PublicHolidaysId1",
                        column: x => x.PublicHolidaysId1,
                        principalTable: "PublicHolidays",
                        principalColumn: "PublicHolidaysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPublicHolidayEntity_UserCompanyProfiles_ProfilesUserCompanyProfilId",
                        column: x => x.ProfilesUserCompanyProfilId,
                        principalTable: "UserCompanyProfiles",
                        principalColumn: "UserCompanyProfilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPublicHolidayEntity_UserCompanyProfiles_profileUserCompanyProfilId",
                        column: x => x.profileUserCompanyProfilId,
                        principalTable: "UserCompanyProfiles",
                        principalColumn: "UserCompanyProfilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCategories_UserProfileId",
                table: "EmployeeCategories",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPublicHolidayEntity_ProfilesUserCompanyProfilId",
                table: "UserPublicHolidayEntity",
                column: "ProfilesUserCompanyProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPublicHolidayEntity_profileUserCompanyProfilId",
                table: "UserPublicHolidayEntity",
                column: "profileUserCompanyProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPublicHolidayEntity_PublicHolidaysId",
                table: "UserPublicHolidayEntity",
                column: "PublicHolidaysId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPublicHolidayEntity_PublicHolidaysId1",
                table: "UserPublicHolidayEntity",
                column: "PublicHolidaysId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCategories");

            migrationBuilder.DropTable(
                name: "UserPublicHolidayEntity");

            migrationBuilder.DropTable(
                name: "PublicHolidays");
        }
    }
}
