﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSites;

namespace ReviewsSites.Migrations
{
    [DbContext(typeof(ReviewsContext))]
    [Migration("20190305033019_addedMoreCategories")]
    partial class addedMoreCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSites.Models.Beer", b =>
                {
                    b.Property<int>("BeerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Abv");

                    b.Property<string>("Brewery");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImgPath");

                    b.Property<string>("Name");

                    b.Property<float>("Rating");

                    b.HasKey("BeerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Beers");

                    b.HasData(
                        new { BeerId = 1, Abv = 6.2f, Brewery = "Three Floyds", CategoryId = 1, Description = "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", ImgPath = "/Images/Zombiedust.png", Name = "Zombie Dust", Rating = 4.8f },
                        new { BeerId = 2, Abv = 10f, Brewery = "Bells", CategoryId = 1, Description = "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", ImgPath = "/Images/Hopslam.png", Name = "Hopslam", Rating = 4.6f },
                        new { BeerId = 3, Abv = 7.8f, Brewery = "Lord Hobo", CategoryId = 1, Description = "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", ImgPath = "/Images/Boomsauce.png", Name = "Boomsauce", Rating = 3f }
                    );
                });

            modelBuilder.Entity("ReviewsSites.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DetailDescription");

                    b.Property<string>("ImgPath");

                    b.Property<string>("Style");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new { CategoryId = 1, DetailDescription = "Characterized by floral, fruity, citrus-like, piney or resinous American-variety hop character, the IPA beer style is all about hop flavor, aroma and bitterness. This has been the most-entered category at the Great American Beer Festival for more than a decade, and is the top-selling craft beer style in supermarkets and liquor stores across the U.S.", ImgPath = "/Images/IPA.png", Style = "IPA" },
                        new { CategoryId = 2, DetailDescription = "A stout beer is a dark, sometimes bitter beer that was first commercially produced in the 1730s. The first versions of this drink were from Ireland, where the still most popular stout is produced by Guinness. Yet Guinness is only one of the many companies that produce and market stouts.", ImgPath = "/Images/Stout.png", Style = "Stout" },
                        new { CategoryId = 3, DetailDescription = "Pale lager is a very pale-to-golden-colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", ImgPath = "/Images/lager.png", Style = "Pale Lager" }
                    );
                });

            modelBuilder.Entity("ReviewsSites.Models.UserReview", b =>
                {
                    b.Property<int>("UserReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeerId");

                    b.Property<int>("UserRating");

                    b.Property<string>("UserText");

                    b.HasKey("UserReviewId");

                    b.HasIndex("BeerId");

                    b.ToTable("UserReviews");

                    b.HasData(
                        new { UserReviewId = 1, BeerId = 1, UserRating = 3, UserText = "This rocks" }
                    );
                });

            modelBuilder.Entity("ReviewsSites.Models.Beer", b =>
                {
                    b.HasOne("ReviewsSites.Models.Category")
                        .WithMany("Beers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReviewsSites.Models.UserReview", b =>
                {
                    b.HasOne("ReviewsSites.Models.Beer")
                        .WithMany("UserReviews")
                        .HasForeignKey("BeerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
