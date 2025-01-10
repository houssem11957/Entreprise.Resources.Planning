using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class payrollSchema1165 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPublicHolidayEntity");

            migrationBuilder.CreateTable(
                name: "PublicHolidaysEntityUserCompanyProfileEntity",
                columns: table => new
                {
                    ProfilesUserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    PublicHolidaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidaysEntityUserCompanyProfileEntity", x => new { x.ProfilesUserCompanyProfilId, x.PublicHolidaysId });
                    table.ForeignKey(
                        name: "FK_PublicHolidaysEntityUserCompanyProfileEntity_PublicHolidays_PublicHolidaysId",
                        column: x => x.PublicHolidaysId,
                        principalTable: "PublicHolidays",
                        principalColumn: "PublicHolidaysId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicHolidaysEntityUserCompanyProfileEntity_UserCompanyProfiles_ProfilesUserCompanyProfilId",
                        column: x => x.ProfilesUserCompanyProfilId,
                        principalTable: "UserCompanyProfiles",
                        principalColumn: "UserCompanyProfilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublicHolidaysEntityUserCompanyProfileEntity_PublicHolidaysId",
                table: "PublicHolidaysEntityUserCompanyProfileEntity",
                column: "PublicHolidaysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicHolidaysEntityUserCompanyProfileEntity");

            migrationBuilder.CreateTable(
                name: "UserPublicHolidayEntity",
                columns: table => new
                {
                    UserPublicHolidayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    profileUserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    PublicHolidaysId1 = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ProfilesUserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    PublicHolidaysId = table.Column<int>(type: "int", nullable: false),
                    UserCompanyProfilId = table.Column<int>(type: "int", nullable: false)
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
    }
}
