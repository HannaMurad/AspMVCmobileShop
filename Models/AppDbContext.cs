using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCMobileSlut.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Mobile> Mobiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "iPhone" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Samsung" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "One Plus" });

            //seed pies

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 1,
                Name = "iPhone 12",
                Price = 8790M,
                ShortDescription = "64 GB (svart)",
                LongDescription =
                    "Spänn fast dig för en häpnadsväckande hastighet hos iPhone 12 smartphone. Ta fantastiska foton och videor i hög upplösning med 12Mpx Dual-kamerasystem och se dem på din 6.1 Super Retina XDR OLED - pekskärm.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone01.jpg",
                InStock = true,
                IsMobileOfTheWeek = true,
                ImageThumbnailUrl = "/Images/Products/cellphone01.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 2,
                Name = "iPhone 11",
                Price = 7290M,
                ShortDescription = "128 GB (svart)",
                LongDescription =
                    "Öppna ögonen och upplev världens skönhet från ett nytt perspektiv med iPhone 11 och dess skärm på 6.1 tum. Telefonen kommer med ett snabbt chip, avancerad teknik, smidig drift och innovativa funktioner.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone02.jpg",
                InStock = true,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl =
                    "/Images/Products/cellphone02.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 3,
                Name = "OnePlus Nord N100",
                Price = 1190M,
                ShortDescription = "(midnight frost)",
                LongDescription =
                    "OnePlus Nord N100 smartphone kommer med en effektiv Snapdragon 460 processor och ett 5000mAh batteri med 18W snabbladdning",
                CategoryId = 3,
                ImageUrl = "/Images/Products/cellphone03.jpg",
                InStock = true,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl = "/Images/Products/cellphone03.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 4,
                Name = "iPhone 12 Mini",
                Price = 7790M,
                ShortDescription = "64 GB (svart)",
                LongDescription =
                    "Få fantastiska funktioner i ett kompakt format med iPhone 12 Mini smartphone som kommer med 12Mpx Dual-kamerasystem, A14 Bionic chip samt en Super Retina XDR OLED-skärm. Telefonen har magnetladdning, TrueDepth främre kamera och innovativa iOS 14.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone04.jpg",
                InStock = true,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl = "/Images/Products/cellphone04.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 5,
                Name = "iPhone 12 Pro",
                Price = 13490M,
                ShortDescription = "256 GB (pacific blue)",
                LongDescription =
                    " iPhone 12 Pro smartphone har supersnabbt 5G-stöd, banbrytande bakre trippelkamera på 12 Mpx och en kraftfull Apple A14 Bionic-processor. Enheten har också IP68-skydd och tåligt keramiskt skärmglas som täcker skärmen.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone05.jpg",
                InStock = true,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl =
                    "/Images/Products/cellphone05.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 6,
                Name = "iPhone 12 Pro",
                Price = 12490M,
                ShortDescription = "128 GB (pacific blue)",
                LongDescription =
                    "iPhone 12 Pro smartphone har supersnabbt 5G-stöd, banbrytande bakre trippelkamera på 12 Mpx och en kraftfull Apple A14 Bionic-processor. Enheten har också IP68-skydd och tåligt keramiskt skärmglas som täcker skärmen.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone06.jpg",
                InStock = true,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl = "/Images/Products/cellphone06.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 7,
                Name = "Samsung Galaxy A52",
                Price = 3990M,
                ShortDescription = "128 GB (awesome black)",
                LongDescription =
                    "Samsung Galaxy A52 5G smartphone erbjuder en 6,5“ stor Super AMOLED-pekskärm med en uppdateringsfrekvens på 120HZ, ett 4,500mAh-batteri med 25W snabbladdning och nästa generations 5G-anslutning.",
                CategoryId = 2,
                ImageUrl = "/Images/Products/cellphone07.jpg",
                InStock = false,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl = "/Images/Products/cellphone07.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 8,
                Name = "iPhone SE",
                Price = 4690M,
                ShortDescription = " 64 GB (svart)",
                LongDescription =
                    "iPhone SE smartphone är en enhet i fickstorlek, klassiskt designad i glasaluminium. Den har en 4,7-tums Retina HD-pekskärm och en 12Mpx bakre kamera med avancerade funktioner och LED True Tone-blixt.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone08.jpg",
                InStock = true,
                IsMobileOfTheWeek = true,
                ImageThumbnailUrl = "/Images/Products/cellphone08.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 9,
                Name = "iPhone 12 Pro Max",
                Price = 14490M,
                ShortDescription = "256 GB (guld)",
                LongDescription =
                    "iPhone 12 Pro Max smartphone erbjuder en 6,7-tums Super Retina XDR-pekskärm täckt av Ceramic Shield-glas, en trippelkamera på 12 Mpx med många avancerade funktioner och en Apple A14 Bionic-processor med 5G och stor energieffektivitet.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone09.jpg",
                InStock = true,
                IsMobileOfTheWeek = true,
                ImageThumbnailUrl = "/Images/Products/cellphone09.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 10,
                Name = "Samsung Galaxy S21",
                Price = 9490M,
                ShortDescription = "128 GB (phantom gray)",
                LongDescription =
                    "Samsung Galaxy S21 smartphone är en ny högteknologisk enhet med en 6,2 dynamisk AMOLED - skärm med en uppdateringsfrekvens på 120 Hz, en Exynos 2100 5nm - processor med 5G och ett starkt 4000mAh - batteri med snabb trådbunden och trådlös laddning.",
                CategoryId = 2,
                ImageUrl = "/Images/Products/cellphone10.jpg",
                InStock = true,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl = "/Images/Products/cellphone10.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 11,
                Name = "Samsung Galaxy A21",
                Price = 1990M,
                ShortDescription = "32 GB (svart)",
                LongDescription =
                    "Samsung Galaxy A21s smartphone är en snyggt designad enhet med en 6,5 tum stor Infinity-O-pekskärm och skimrande baksida med 48+8+2+2Mpx-fyrkamera. Det långvariga 5,000mAh-batteriet med stöd för 15W snabbladdning låter dig spela spel hela dagen.",
                CategoryId = 2,
                ImageUrl = "/Images/Products/cellphone11.jpg",
                InStock = false,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl =
                    "/Images/Products/cellphone11.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Mobile>().HasData(new Mobile
            {
                MobileId = 12,
                Name = "iPhone 11",
                Price = 7290M,
                ShortDescription = "128 GB (vit)",
                LongDescription =
                    "Öppna ögonen och upplev världens skönhet från ett nytt perspektiv med iPhone 11 och dess skärm på 6.1 tum. Telefonen kommer med ett snabbt chip, avancerad teknik, smidig drift och innovativa funktioner.",
                CategoryId = 1,
                ImageUrl = "/Images/Products/cellphone12.jpg",
                InStock = false,
                IsMobileOfTheWeek = false,
                ImageThumbnailUrl =
                    "/Images/Products/cellphone12.jpg",
                AllergyInformation = ""
            });
        }
    }
}
