// <auto-generated />
using System;
using AspMVCMobileSlut.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspMVCMobileSlut.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210510011847_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspMVCMobileSlut.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "iPhone"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Samsung"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "One Plus"
                        });
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.Mobile", b =>
                {
                    b.Property<int>("MobileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMobileOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MobileId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Mobiles");

                    b.HasData(
                        new
                        {
                            MobileId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone01.jpg",
                            ImageUrl = "~/Images/Products/cellphone01.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = true,
                            LongDescription = "Spänn fast dig för en häpnadsväckande hastighet hos iPhone 12 smartphone. Ta fantastiska foton och videor i hög upplösning med 12Mpx Dual-kamerasystem och se dem på din 6.1 Super Retina XDR OLED - pekskärm.",
                            Name = "iPhone 12",
                            Price = 8790m,
                            ShortDescription = "64 GB (svart)"
                        },
                        new
                        {
                            MobileId = 2,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone02.jpg",
                            ImageUrl = "~/Images/Products/cellphone02.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = false,
                            LongDescription = "Öppna ögonen och upplev världens skönhet från ett nytt perspektiv med iPhone 11 och dess skärm på 6.1 tum. Telefonen kommer med ett snabbt chip, avancerad teknik, smidig drift och innovativa funktioner.",
                            Name = "iPhone 11",
                            Price = 7290m,
                            ShortDescription = "128 GB (svart)"
                        },
                        new
                        {
                            MobileId = 3,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "~/Images/Products/cellphone03.jpg",
                            ImageUrl = "~/Images/Products/cellphone03.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = false,
                            LongDescription = "OnePlus Nord N100 smartphone kommer med en effektiv Snapdragon 460 processor och ett 5000mAh batteri med 18W snabbladdning",
                            Name = "OnePlus Nord N100",
                            Price = 1190m,
                            ShortDescription = "(midnight frost)"
                        },
                        new
                        {
                            MobileId = 4,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone04.jpg",
                            ImageUrl = "~/Images/Products/cellphone04.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = false,
                            LongDescription = "Få fantastiska funktioner i ett kompakt format med iPhone 12 Mini smartphone som kommer med 12Mpx Dual-kamerasystem, A14 Bionic chip samt en Super Retina XDR OLED-skärm. Telefonen har magnetladdning, TrueDepth främre kamera och innovativa iOS 14.",
                            Name = "iPhone 12 Mini",
                            Price = 7790m,
                            ShortDescription = "64 GB (svart)"
                        },
                        new
                        {
                            MobileId = 5,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone05.jpg",
                            ImageUrl = "~/Images/Products/cellphone05.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = false,
                            LongDescription = " iPhone 12 Pro smartphone har supersnabbt 5G-stöd, banbrytande bakre trippelkamera på 12 Mpx och en kraftfull Apple A14 Bionic-processor. Enheten har också IP68-skydd och tåligt keramiskt skärmglas som täcker skärmen.",
                            Name = "iPhone 12 Pro",
                            Price = 13490m,
                            ShortDescription = "256 GB (pacific blue)"
                        },
                        new
                        {
                            MobileId = 6,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone06.jpg",
                            ImageUrl = "~/Images/Products/cellphone06.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = false,
                            LongDescription = "iPhone 12 Pro smartphone har supersnabbt 5G-stöd, banbrytande bakre trippelkamera på 12 Mpx och en kraftfull Apple A14 Bionic-processor. Enheten har också IP68-skydd och tåligt keramiskt skärmglas som täcker skärmen.",
                            Name = "iPhone 12 Pro",
                            Price = 12490m,
                            ShortDescription = "128 GB (pacific blue)"
                        },
                        new
                        {
                            MobileId = 7,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/Images/Products/cellphone07.jpg",
                            ImageUrl = "~/Images/Products/cellphone07.jpg",
                            InStock = false,
                            IsMobileOfTheWeek = false,
                            LongDescription = "Samsung Galaxy A52 5G smartphone erbjuder en 6,5“ stor Super AMOLED-pekskärm med en uppdateringsfrekvens på 120HZ, ett 4,500mAh-batteri med 25W snabbladdning och nästa generations 5G-anslutning.",
                            Name = "Samsung Galaxy A52",
                            Price = 3990m,
                            ShortDescription = "128 GB (awesome black)"
                        },
                        new
                        {
                            MobileId = 8,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone08.jpg",
                            ImageUrl = "~/Images/Products/cellphone08.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = true,
                            LongDescription = "iPhone SE smartphone är en enhet i fickstorlek, klassiskt designad i glasaluminium. Den har en 4,7-tums Retina HD-pekskärm och en 12Mpx bakre kamera med avancerade funktioner och LED True Tone-blixt.",
                            Name = "iPhone SE",
                            Price = 4690m,
                            ShortDescription = " 64 GB (svart)"
                        },
                        new
                        {
                            MobileId = 9,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone09.jpg",
                            ImageUrl = "~/Images/Products/cellphone09.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = true,
                            LongDescription = "iPhone 12 Pro Max smartphone erbjuder en 6,7-tums Super Retina XDR-pekskärm täckt av Ceramic Shield-glas, en trippelkamera på 12 Mpx med många avancerade funktioner och en Apple A14 Bionic-processor med 5G och stor energieffektivitet.",
                            Name = "iPhone 12 Pro Max",
                            Price = 14490m,
                            ShortDescription = "256 GB (guld)"
                        },
                        new
                        {
                            MobileId = 10,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/Images/Products/cellphone10.jpg",
                            ImageUrl = "~/Images/Products/cellphone10.jpg",
                            InStock = true,
                            IsMobileOfTheWeek = false,
                            LongDescription = "Samsung Galaxy S21 smartphone är en ny högteknologisk enhet med en 6,2 dynamisk AMOLED - skärm med en uppdateringsfrekvens på 120 Hz, en Exynos 2100 5nm - processor med 5G och ett starkt 4000mAh - batteri med snabb trådbunden och trådlös laddning.",
                            Name = "Samsung Galaxy S21",
                            Price = 9490m,
                            ShortDescription = "128 GB (phantom gray)"
                        },
                        new
                        {
                            MobileId = 11,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "~/Images/Products/cellphone11.jpg",
                            ImageUrl = "~/Images/Products/cellphone11.jpg",
                            InStock = false,
                            IsMobileOfTheWeek = false,
                            LongDescription = "Samsung Galaxy A21s smartphone är en snyggt designad enhet med en 6,5 tum stor Infinity-O-pekskärm och skimrande baksida med 48+8+2+2Mpx-fyrkamera. Det långvariga 5,000mAh-batteriet med stöd för 15W snabbladdning låter dig spela spel hela dagen.",
                            Name = "Samsung Galaxy A21",
                            Price = 1990m,
                            ShortDescription = "32 GB (svart)"
                        },
                        new
                        {
                            MobileId = 12,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "~/Images/Products/cellphone12.jpg",
                            ImageUrl = "~/Images/Products/cellphone12.jpg",
                            InStock = false,
                            IsMobileOfTheWeek = false,
                            LongDescription = "Öppna ögonen och upplev världens skönhet från ett nytt perspektiv med iPhone 11 och dess skärm på 6.1 tum. Telefonen kommer med ett snabbt chip, avancerad teknik, smidig drift och innovativa funktioner.",
                            Name = "iPhone 11",
                            Price = 7290m,
                            ShortDescription = "128 GB (vit)"
                        });
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MobileId")
                        .HasColumnType("int");

                    b.Property<int>("MoblieId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailsId");

                    b.HasIndex("MobileId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MobileId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("MobileId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.Mobile", b =>
                {
                    b.HasOne("AspMVCMobileSlut.Models.Category", "Category")
                        .WithMany("Mobiles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.OrderDetails", b =>
                {
                    b.HasOne("AspMVCMobileSlut.Models.Mobile", "Mobile")
                        .WithMany()
                        .HasForeignKey("MobileId");

                    b.HasOne("AspMVCMobileSlut.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AspMVCMobileSlut.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("AspMVCMobileSlut.Models.Mobile", "Mobile")
                        .WithMany()
                        .HasForeignKey("MobileId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
