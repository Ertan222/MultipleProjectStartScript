using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesConsumingAPI.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    cityid = table.Column<int>(name: "city_id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cities", x => x.cityid);
                });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "city_id", "name" },
                values: new object[,]
                {
                    { 1, "Tokyo" },
                    { 2, "Tokyo" },
                    { 3, "Tokyo" },
                    { 4, "Tokyo" },
                    { 5, "Tokyo" },
                    { 6, "Tokyo" },
                    { 7, "Tokyo" },
                    { 8, "Tokyo" },
                    { 9, "Tokyo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cities");
        }
    }
}
