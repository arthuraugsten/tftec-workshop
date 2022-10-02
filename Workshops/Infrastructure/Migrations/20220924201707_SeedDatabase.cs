using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Workshops.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Workshops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workshops", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Workshops",
                columns: new[] { "Id", "Date", "Name" },
                values: new object[,]
                {
                    { new Guid("258492ae-0133-47fc-b3f1-75c0ac33a291"), new DateTime(2022, 10, 9, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1498), "Workshop Azure Network" },
                    { new Guid("59d1e381-5484-4580-9eb4-8fc364075225"), new DateTime(2022, 12, 23, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1516), "Workshop Azure Cognitive Services" },
                    { new Guid("952347f8-11af-4bf3-ab62-91e9794d56ec"), new DateTime(2022, 12, 8, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1515), "Workshop Azure Firewall" },
                    { new Guid("e867c517-ce35-4fe5-8cae-b944dbfd9d54"), new DateTime(2022, 11, 8, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1512), "Workshop Azure Kubernetes Service" },
                    { new Guid("f2b16552-389a-442c-a176-ee46b3ce53a7"), new DateTime(2022, 11, 23, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1514), "Workshop Azyre Container Instance" },
                    { new Guid("f55add9c-350a-4b14-bd1d-f13aca067846"), new DateTime(2022, 10, 24, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1510), "Workshop Terraform" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workshops");
        }
    }
}
