using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspMVCMobileSlut.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(maxLength: 10, nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    State = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 25, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(nullable: false),
                    OrderPlaced = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mobiles",
                columns: table => new
                {
                    MobileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true),
                    AllergyInformation = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    IsMobileOfTheWeek = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobiles", x => x.MobileId);
                    table.ForeignKey(
                        name: "FK_Mobiles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    MoblieId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    MobileId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Mobiles_MobileId",
                        column: x => x.MobileId,
                        principalTable: "Mobiles",
                        principalColumn: "MobileId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileId = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShoppingCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Mobiles_MobileId",
                        column: x => x.MobileId,
                        principalTable: "Mobiles",
                        principalColumn: "MobileId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "iPhone", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Samsung", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "One Plus", null });

            migrationBuilder.InsertData(
                table: "Mobiles",
                columns: new[] { "MobileId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsMobileOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "~/Images/Products/cellphone01.jpg", "~/Images/Products/cellphone01.jpg", true, true, "Spänn fast dig för en häpnadsväckande hastighet hos iPhone 12 smartphone. Ta fantastiska foton och videor i hög upplösning med 12Mpx Dual-kamerasystem och se dem på din 6.1 Super Retina XDR OLED - pekskärm.", "iPhone 12", 8790m, "64 GB (svart)" },
                    { 2, "", 1, "~/Images/Products/cellphone02.jpg", "~/Images/Products/cellphone02.jpg", true, false, "Öppna ögonen och upplev världens skönhet från ett nytt perspektiv med iPhone 11 och dess skärm på 6.1 tum. Telefonen kommer med ett snabbt chip, avancerad teknik, smidig drift och innovativa funktioner.", "iPhone 11", 7290m, "128 GB (svart)" },
                    { 4, "", 1, "~/Images/Products/cellphone04.jpg", "~/Images/Products/cellphone04.jpg", true, false, "Få fantastiska funktioner i ett kompakt format med iPhone 12 Mini smartphone som kommer med 12Mpx Dual-kamerasystem, A14 Bionic chip samt en Super Retina XDR OLED-skärm. Telefonen har magnetladdning, TrueDepth främre kamera och innovativa iOS 14.", "iPhone 12 Mini", 7790m, "64 GB (svart)" },
                    { 5, "", 1, "~/Images/Products/cellphone05.jpg", "~/Images/Products/cellphone05.jpg", true, false, " iPhone 12 Pro smartphone har supersnabbt 5G-stöd, banbrytande bakre trippelkamera på 12 Mpx och en kraftfull Apple A14 Bionic-processor. Enheten har också IP68-skydd och tåligt keramiskt skärmglas som täcker skärmen.", "iPhone 12 Pro", 13490m, "256 GB (pacific blue)" },
                    { 6, "", 1, "~/Images/Products/cellphone06.jpg", "~/Images/Products/cellphone06.jpg", true, false, "iPhone 12 Pro smartphone har supersnabbt 5G-stöd, banbrytande bakre trippelkamera på 12 Mpx och en kraftfull Apple A14 Bionic-processor. Enheten har också IP68-skydd och tåligt keramiskt skärmglas som täcker skärmen.", "iPhone 12 Pro", 12490m, "128 GB (pacific blue)" },
                    { 8, "", 1, "~/Images/Products/cellphone08.jpg", "~/Images/Products/cellphone08.jpg", true, true, "iPhone SE smartphone är en enhet i fickstorlek, klassiskt designad i glasaluminium. Den har en 4,7-tums Retina HD-pekskärm och en 12Mpx bakre kamera med avancerade funktioner och LED True Tone-blixt.", "iPhone SE", 4690m, " 64 GB (svart)" },
                    { 9, "", 1, "~/Images/Products/cellphone09.jpg", "~/Images/Products/cellphone09.jpg", true, true, "iPhone 12 Pro Max smartphone erbjuder en 6,7-tums Super Retina XDR-pekskärm täckt av Ceramic Shield-glas, en trippelkamera på 12 Mpx med många avancerade funktioner och en Apple A14 Bionic-processor med 5G och stor energieffektivitet.", "iPhone 12 Pro Max", 14490m, "256 GB (guld)" },
                    { 12, "", 1, "~/Images/Products/cellphone12.jpg", "~/Images/Products/cellphone12.jpg", false, false, "Öppna ögonen och upplev världens skönhet från ett nytt perspektiv med iPhone 11 och dess skärm på 6.1 tum. Telefonen kommer med ett snabbt chip, avancerad teknik, smidig drift och innovativa funktioner.", "iPhone 11", 7290m, "128 GB (vit)" },
                    { 7, "", 2, "~/Images/Products/cellphone07.jpg", "~/Images/Products/cellphone07.jpg", false, false, "Samsung Galaxy A52 5G smartphone erbjuder en 6,5“ stor Super AMOLED-pekskärm med en uppdateringsfrekvens på 120HZ, ett 4,500mAh-batteri med 25W snabbladdning och nästa generations 5G-anslutning.", "Samsung Galaxy A52", 3990m, "128 GB (awesome black)" },
                    { 10, "", 2, "~/Images/Products/cellphone10.jpg", "~/Images/Products/cellphone10.jpg", true, false, "Samsung Galaxy S21 smartphone är en ny högteknologisk enhet med en 6,2 dynamisk AMOLED - skärm med en uppdateringsfrekvens på 120 Hz, en Exynos 2100 5nm - processor med 5G och ett starkt 4000mAh - batteri med snabb trådbunden och trådlös laddning.", "Samsung Galaxy S21", 9490m, "128 GB (phantom gray)" },
                    { 11, "", 2, "~/Images/Products/cellphone11.jpg", "~/Images/Products/cellphone11.jpg", false, false, "Samsung Galaxy A21s smartphone är en snyggt designad enhet med en 6,5 tum stor Infinity-O-pekskärm och skimrande baksida med 48+8+2+2Mpx-fyrkamera. Det långvariga 5,000mAh-batteriet med stöd för 15W snabbladdning låter dig spela spel hela dagen.", "Samsung Galaxy A21", 1990m, "32 GB (svart)" },
                    { 3, "", 3, "~/Images/Products/cellphone03.jpg", "~/Images/Products/cellphone03.jpg", true, false, "OnePlus Nord N100 smartphone kommer med en effektiv Snapdragon 460 processor och ett 5000mAh batteri med 18W snabbladdning", "OnePlus Nord N100", 1190m, "(midnight frost)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mobiles_CategoryId",
                table: "Mobiles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_MobileId",
                table: "OrderDetails",
                column: "MobileId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_MobileId",
                table: "ShoppingCartItems",
                column: "MobileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Mobiles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
