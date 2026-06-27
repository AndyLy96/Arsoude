using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arsoude_Backend.Migrations
{
    public partial class testRelease2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "8f4b35da-e4ba-48e2-bf37-8afb739cdb88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38e6273e-e2be-4740-8929-22267507a7fe", "AQAAAAEAACcQAAAAEIcUQ+kKhmgiYkbYpL3NTdU0kmtPmd4huhEQpN6PPBzX+ThGbtttkZHQjNRk5x8xbA==", "2a0ee01a-97a6-4ff9-8cab-c9dc78dcc162" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db8a260f-5428-4762-8759-ba186fa379b8", "AQAAAAEAACcQAAAAEJ3Nlir8iKc7HpKlAq1Pkql+3oCGGeQZLI4KbJ/EpTHBZJILKn+poe6N+oZnziub1g==", "3e2fc6a7-de7b-496a-9e03-f3765c28bb85" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111113",
                column: "ConcurrencyStamp",
                value: "3ef86f99-8a7b-47f3-83d9-9fb5a2e67140");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f9bf86-219d-46c2-8555-0b61e4a91a2e", "AQAAAAEAACcQAAAAEDfK0eF/x7LDWtHYjbfW6w+U3j6pOcWxFyWNnbNQ1FZrag/pu3eb7COHopk5ZoTRvA==", "81aaed0d-e096-4e09-84a6-75801d9e2913" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "089675c7-1bba-4127-8ce8-43279a564fea", "AQAAAAEAACcQAAAAEPvyZu6JiubvZ/4qzBQLcmWRrJqGMHLKoHa8MWOdPgbEPIMC63PpzLuLOjvRM3JJGA==", "8493e507-32e6-40cd-ad30-85889cfb8c9f" });
        }
    }
}
