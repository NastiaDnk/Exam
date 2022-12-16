using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamDB.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDateTime",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 1,
                column: "AppointmentDateTime",
                value: new DateTime(2022, 12, 30, 9, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 2,
                column: "AppointmentDateTime",
                value: new DateTime(2022, 12, 30, 10, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 3,
                column: "AppointmentDateTime",
                value: new DateTime(2022, 12, 30, 11, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 4,
                column: "AppointmentDateTime",
                value: new DateTime(2022, 12, 30, 14, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 5,
                column: "AppointmentDateTime",
                value: new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "Id",
                keyValue: 6,
                column: "AppointmentDateTime",
                value: new DateTime(2022, 12, 30, 18, 10, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentDateTime",
                table: "Appointment");
        }
    }
}
