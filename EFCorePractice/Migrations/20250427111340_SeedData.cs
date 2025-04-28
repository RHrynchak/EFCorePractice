using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCorePractice.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "Description", "IsForLoyalClients", "Percentage" },
                values: new object[,]
                {
                    { 1, "Spring Sale", false, 0.1m },
                    { 2, "Loyalty Discount", true, 0.15m }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Capacity", "Number", "Type" },
                values: new object[,]
                {
                    { 1, 100, 0, "Standart" },
                    { 2, 50, 0, "VIP" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AgeRestriction", "Description", "Director", "Duration", "Genre", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, 13, "A thief who steals corporate secrets through dream-sharing technology.", "Christopher Nolan", new TimeSpan(0, 2, 28, 0, 0), "Sci-Fi", 2010, "Inception" },
                    { 2, 16, "A hacker discovers reality is a simulation.", "The Wachowskis", new TimeSpan(0, 2, 16, 0, 0), "Action", 1999, "The Matrix" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BonusPoints", "Email", "Name", "Role" },
                values: new object[,]
                {
                    { 1, 0, "admin@cinema.com", "Admin", "Admin" },
                    { 2, 120, "olga@gmail.com", "Olga", "Client" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "DiscountId", "PurchaseDate", "TotalPrice", "UserId" },
                values: new object[] { 1, 2, new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), 300m, 2 });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "HallId", "MovieId", "StartTime", "Status", "TicketPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 4, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), "Active", 150m },
                    { 2, 2, 2, new DateTime(2025, 4, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), "Active", 200m }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Price", "SaleId", "SeatNumber", "SessionId", "Status" },
                values: new object[,]
                {
                    { 1, 150m, 1, "A1", 1, "Purchased" },
                    { 2, 150m, 1, "A2", 1, "Purchased" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
