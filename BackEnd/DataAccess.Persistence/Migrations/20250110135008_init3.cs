﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PerformanceScore",
                table: "EmployeeEvaluations",
                type: "decimal(10,4)",
                precision: 10,
                scale: 4,
                nullable: true,
                defaultValue: 100m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldPrecision: 10,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "AttendanceScore",
                table: "EmployeeEvaluations",
                type: "decimal(10,4)",
                precision: 10,
                scale: 4,
                nullable: true,
                defaultValue: 20m,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldPrecision: 10,
                oldScale: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PerformanceScore",
                table: "EmployeeEvaluations",
                type: "decimal(10,4)",
                precision: 10,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldPrecision: 10,
                oldScale: 4,
                oldDefaultValue: 100m);

            migrationBuilder.AlterColumn<decimal>(
                name: "AttendanceScore",
                table: "EmployeeEvaluations",
                type: "decimal(10,4)",
                precision: 10,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,4)",
                oldPrecision: 10,
                oldScale: 4,
                oldDefaultValue: 20m);
        }
    }
}
