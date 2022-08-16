using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "CreatedAt", "Day", "Ingredients", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("1153e59d-746b-4842-a364-5d9b941acb97"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9849), 3, "Spaghetti, olive oil, garlic, cauliflower, chickpeas", "Spaghetti with cauliflower sauce and chickpeas", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9849) },
                    { new Guid("1dc83e82-402d-4b4c-b7cd-33fe3add0f22"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9841), 2, "Spaghetti, olive oil, garlic, lentils", "Spaghetti with lentils", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9841) },
                    { new Guid("1e144519-01ea-4adf-9cf3-bd50a4949558"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9782), 1, "Spaghetti, olive oil, garlic", "Spaghetti aglio y oleo", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9782) },
                    { new Guid("7684803c-a4e6-4817-899a-91816a5b2783"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9862), 5, "Margherita or mussarela", "Pizza", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9862) },
                    { new Guid("79a66486-ae5c-45e8-8386-04227c2c228e"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9877), 7, "hamburger of chickpeas, lentils, beans, soy", "Hamburger", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9877) },
                    { new Guid("b0f3852e-3a19-4d6a-83eb-452aa68ce15d"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9855), 4, "Rice, lentils, potato, peas,carrpts", "Risotto", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9855) },
                    { new Guid("d209f1a7-0730-4e0a-bb5f-75db00232db1"), new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9870), 6, "gohan, tofu, mushrooms,soy sauce, spring onion, fried eggplant, courgette ", "Donburi", new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9870) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("1153e59d-746b-4842-a364-5d9b941acb97"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("1dc83e82-402d-4b4c-b7cd-33fe3add0f22"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("1e144519-01ea-4adf-9cf3-bd50a4949558"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("7684803c-a4e6-4817-899a-91816a5b2783"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("79a66486-ae5c-45e8-8386-04227c2c228e"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("b0f3852e-3a19-4d6a-83eb-452aa68ce15d"));

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "Id",
                keyValue: new Guid("d209f1a7-0730-4e0a-bb5f-75db00232db1"));
        }
    }
}
