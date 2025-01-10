using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_attendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankingInformations_Users_UserId",
                table: "BankingInformations");

            migrationBuilder.DropForeignKey(
                name: "FK_Sanctions_Users_UserId",
                table: "Sanctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sanctions",
                table: "Sanctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BankingInformations",
                table: "BankingInformations");

            migrationBuilder.RenameTable(
                name: "Sanctions",
                newName: "ERP_Sanctions_Table");

            migrationBuilder.RenameTable(
                name: "BankingInformations",
                newName: "ERP_BankingInformations_Table");

            migrationBuilder.RenameIndex(
                name: "IX_Sanctions_UserId",
                table: "ERP_Sanctions_Table",
                newName: "IX_ERP_Sanctions_Table_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BankingInformations_UserId",
                table: "ERP_BankingInformations_Table",
                newName: "IX_ERP_BankingInformations_Table_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ERP_Sanctions_Table",
                table: "ERP_Sanctions_Table",
                column: "SanctionsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ERP_BankingInformations_Table",
                table: "ERP_BankingInformations_Table",
                column: "BankingInformations_Id");

            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    LeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RejectedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK_Leaves_UserCompanyProfiles_UserCompanyProfilId",
                        column: x => x.UserCompanyProfilId,
                        principalTable: "UserCompanyProfiles",
                        principalColumn: "UserCompanyProfilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pointages",
                columns: table => new
                {
                    PointageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClockIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalHours = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pointages", x => x.PointageId);
                    table.ForeignKey(
                        name: "FK_Pointages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkingTimeSchedules",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDay = table.Column<int>(type: "int", nullable: true),
                    StartDay = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BreakDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalWorkingHours = table.Column<int>(type: "int", nullable: false),
                    WorkDays = table.Column<int>(type: "int", nullable: false),
                    ShiftType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCompanyProfilId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingTimeSchedules", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_WorkingTimeSchedules_UserCompanyProfiles_UserCompanyProfilId",
                        column: x => x.UserCompanyProfilId,
                        principalTable: "UserCompanyProfiles",
                        principalColumn: "UserCompanyProfilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_UserCompanyProfilId",
                table: "Leaves",
                column: "UserCompanyProfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Pointages_UserId",
                table: "Pointages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingTimeSchedules_UserCompanyProfilId",
                table: "WorkingTimeSchedules",
                column: "UserCompanyProfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_ERP_BankingInformations_Table_Users_UserId",
                table: "ERP_BankingInformations_Table",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ERP_Sanctions_Table_Users_UserId",
                table: "ERP_Sanctions_Table",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ERP_BankingInformations_Table_Users_UserId",
                table: "ERP_BankingInformations_Table");

            migrationBuilder.DropForeignKey(
                name: "FK_ERP_Sanctions_Table_Users_UserId",
                table: "ERP_Sanctions_Table");

            migrationBuilder.DropTable(
                name: "Leaves");

            migrationBuilder.DropTable(
                name: "Pointages");

            migrationBuilder.DropTable(
                name: "WorkingTimeSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ERP_Sanctions_Table",
                table: "ERP_Sanctions_Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ERP_BankingInformations_Table",
                table: "ERP_BankingInformations_Table");

            migrationBuilder.RenameTable(
                name: "ERP_Sanctions_Table",
                newName: "Sanctions");

            migrationBuilder.RenameTable(
                name: "ERP_BankingInformations_Table",
                newName: "BankingInformations");

            migrationBuilder.RenameIndex(
                name: "IX_ERP_Sanctions_Table_UserId",
                table: "Sanctions",
                newName: "IX_Sanctions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ERP_BankingInformations_Table_UserId",
                table: "BankingInformations",
                newName: "IX_BankingInformations_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sanctions",
                table: "Sanctions",
                column: "SanctionsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankingInformations",
                table: "BankingInformations",
                column: "BankingInformations_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankingInformations_Users_UserId",
                table: "BankingInformations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sanctions_Users_UserId",
                table: "Sanctions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
