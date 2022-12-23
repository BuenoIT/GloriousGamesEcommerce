using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GloriousGamesEcommerce.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Switch", "Embark on a new Pokémon adventure.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/1.jpg", "Pokémon Violet", 79.959999999999994 },
                    { 2, "Switch", "Hogwarts Legacy is an open-world action RPG set in the world introduced in the Harry Potter books.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/2.jpg", "Hogwarts Legacy Deluxe", 89.959999999999994 },
                    { 3, "Switch", "Worlds are colliding in Sonic the Hedgehog's newest high-speed adventure!", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/3.jpg", "Sonic Frontiers", 79.959999999999994 },
                    { 4, "Xbox One", "Enjoy a more true-to-life football experience in FIFA 23 with new gameplay features that create risk-versus-reward shooting, new free kick, penalty, and corner mechanics, and more football variety.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/4.jpg", "FIFA 23", 49.960000000000001 },
                    { 5, "Xbox One", "Over twenty years ago in harran, we fought the virus—and lost. Now, we’re losing again.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/5.jpg", "Dying Light 2", 39.950000000000003 },
                    { 6, "Xbox One", "Cyberpunk 2077 has several updates planned for the new year that are planned to address a number of the issues that users have faced in the game.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/6.jpg", "Cyberpunk 2077", 39.859999999999999 },
                    { 7, "PS4", "Witness what makes Task Force 141 the legendary squad it is today in Call of Duty: Modern Warfare II.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/7.jpg", "Call Of Duty Modern Warfare 2", 89.989999999999995 },
                    { 8, "PS4", "Embark on an epic and heartfelt journey as Kratos and Atreus struggle with holding on and letting go.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/8.jpg", "God of War Ragnarök", 79.989999999999995 },
                    { 9, "PS4", "FINAL FANTASY VII – REUNION is a remaster of CRISIS CORE, featuring a complete HD graphics overhaul, remastered soundtrack, and an updated combat system.", "https://gloriousgamesecommerce.blob.core.windows.net/gloriousgames/9.jpg", "Final Fantasy VII Reunion", 64.959999999999994 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);
        }
    }
}
