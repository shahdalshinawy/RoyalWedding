using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeddingPlanner.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    NumOfPeople = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Passward = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsManager = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    B_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    B_GrdTotal = table.Column<int>(type: "int", nullable: false),
                    B_Advance = table.Column<int>(type: "int", nullable: false),
                    B_Balance = table.Column<int>(type: "int", nullable: false),
                    Profit = table.Column<double>(type: "float", nullable: false),
                    HallId = table.Column<int>(type: "int", nullable: false),
                    StaffBookingID = table.Column<int>(type: "int", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Bookings_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Bookings_Staffs_StaffBookingID",
                        column: x => x.StaffBookingID,
                        principalTable: "Staffs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BookingDataID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dishes_Bookings_BookingDataID",
                        column: x => x.BookingDataID,
                        principalTable: "Bookings",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    BookingDataID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Drinks_Bookings_BookingDataID",
                        column: x => x.BookingDataID,
                        principalTable: "Bookings",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Customer_Address", "Customer_Name", "Customer_Phone" },
                values: new object[,]
                {
                    { 1, "Egypt-Cairo-Giza", "Fareed", "01234567896" },
                    { 2, "Egypt-Cairo-Giza", "Fareed", "01234567896" }
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "ID", "BookingDataID", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, null, "Meat", 90, 0 },
                    { 2, null, "Fish", 100, 0 },
                    { 3, null, "Chicken", 80, 0 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "ID", "BookingDataID", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, null, "Soda", 20, 0 },
                    { 2, null, "Water", 10, 0 },
                    { 3, null, "Juice", 15, 0 }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Name", "NumOfPeople", "Price" },
                values: new object[,]
                {
                    { 1, "Royal I", 100, 19000 },
                    { 2, "Royal II", 150, 25000 },
                    { 3, "Royal III", 200, 40000 },
                    { 4, "Royal IV", 300, 50000 }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "ID", "IsManager", "S_Gender", "S_Name", "S_Passward", "S_Phone" },
                values: new object[,]
                {
                    { 1, true, "Female", "Nour", "1234567", "01234567891" },
                    { 2, true, "Female", "Nada", "1234567", "01019658193" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerID",
                table: "Bookings",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_HallId",
                table: "Bookings",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_StaffBookingID",
                table: "Bookings",
                column: "StaffBookingID");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_BookingDataID",
                table: "Dishes",
                column: "BookingDataID");

            migrationBuilder.CreateIndex(
                name: "IX_Drinks_BookingDataID",
                table: "Drinks",
                column: "BookingDataID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
