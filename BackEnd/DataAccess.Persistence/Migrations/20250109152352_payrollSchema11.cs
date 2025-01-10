using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class payrollSchema11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserCompanyProfilId",
                table: "UserPublicHolidayEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCompanyProfilId",
                table: "UserPublicHolidayEntity");
        }
    }
}
