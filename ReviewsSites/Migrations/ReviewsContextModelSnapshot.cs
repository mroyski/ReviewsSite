﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSites;

namespace ReviewsSites.Migrations
{
    [DbContext(typeof(ReviewsContext))]
    partial class ReviewsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        new { BeerId = 3, Abv = 7.8f, Brewery = "Lord Hobo", CategoryId = 1, Description = "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", ImgPath = "/Images/Boomsauce.png", Name = "Boomsauce", Rating = 3f },
                        new { BeerId = 4, Abv = 4.3f, Brewery = "Diageo", CategoryId = 2, Description = "Guinness is an Irish dry stout that originated in the brewery of Arthur Guinness at St. James's Gate, Dublin, Ireland, in 1759. It is one of the most successful beer brands worldwide, brewed in almost 50 countries and available in over 120. Sales in 2011 amounted to 850 million litres", ImgPath = "/Images/Gusiness.png", Name = "Guinness", Rating = 4.6f },
                        new { BeerId = 5, Abv = 5.8f, Brewery = "Sierra Nevada", CategoryId = 2, Description = "Before Sierra Nevada was a reality, our founders brewed beer at home and dreamed of building a brewery one day. Back then, they brewed the beers they wanted to drink—bold and full of flavor. Stouts had always been a favorite, so when we needed a big and rich beer to test out the brewing system at our fledgling brewery, stout was the obvious choice. Thirty years later, not much has changed. We’re still brewing the beers we want to drink and our classic Stout is the same as it’s ever been—big, rich, bold, black as night and filled with the wild-eyed passion of which dreams are made.", ImgPath = "/Images/Sierra_Nevada_Stout.png", Name = "Sierra Nevada Stout", Rating = 4f },
                        new { BeerId = 6, Abv = 10.3f, Brewery = "Surly Brewing Co", CategoryId = 2, Description = "Russian Imperial Stout contains waves of chocolate, coffee, cherry, raisin, and toffee, plus a non-traditional dose of aromatic hops.", ImgPath = "/Images/DarknessStout.png", Name = "Darkness Russian Stout", Rating = 4.5f },
                        new { BeerId = 7, Abv = 5.4f, Brewery = "Coors Brewing Co", CategoryId = 3, Description = "In addition to Coor's refreshingly unique Blue Moon® Belgian White Belgian-Style Wheat Ale, we also offer our collection of flavorful seasonal and limited release beers that reflect Blue Moon’s twist on various beer styles. An appreciation for the creative process and a passion for brewing enable us at Blue Moon Brewing Company® to offer a welcome twist of flavor in our beers that everyone can enjoy.", ImgPath = "/Images/Wheat-Beer.png", Name = "Blue Moon Mango Wheat", Rating = 3.57f },
                        new { BeerId = 8, Abv = 5.6f, Brewery = "3 Floyds Brewing Co", CategoryId = 3, Description = "An American wheat beer with a refreshing, crisp citrus finish. This delicious session beer is brewed with boatloads of Amarillo hops", ImgPath = "/Images/GumballHeadWheat.png", Name = "GumballHead", Rating = 4.2f },
                        new { BeerId = 9, Abv = 67.5f, Brewery = "BrewMeister", CategoryId = 4, Description = "In certain countries, Brewmeister's Snake Venom beer isn't actually a beer because of hits insanely high ABV. This barley beer has an incredibly high proof that makes it rival, if not exceed, many liquors out there. At around $50 per bottle, this insanely powerful beer will burn a hole in your wallet - and possibly your throat.", ImgPath = "/Images/SnakeVenom.png", Name = "Snake Venom", Rating = 5f },
                        new { BeerId = 10, Abv = 41f, Brewery = "Brew Dog", CategoryId = 4, Description = "It takes a lot to be called one of Scotland's strongest beers, but this high-ABV Imperial IPA definitely does the trick. BrewDog actually made this beer line as a way of showing their brewing prowess and outdoing competitors in the fight to have one of the strongest beers in the world.", ImgPath = "/Images/SinkBismark.png", Name = "Sink The Bismarck", Rating = 5f },
                        new { BeerId = 11, Abv = 29f, Brewery = "Samuel Adams", CategoryId = 4, Description = "Out of all the beers on this list, buying this one is often the easiest and most cost-effective. Sam Adams, after all, is a mainstream beer brand - and it's one of the few mainstream beer brands that's also known for producing special edition batches. ", ImgPath = "/Images/SamAdamsUtopia.png", Name = "Utopias", Rating = 5f }
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
                        new { CategoryId = 3, DetailDescription = "Wheat beer is a beer, usually top-fermented, which is brewed with a large proportion of wheat relative to the amount of malted barley. The two main varieties are Weissbier and Witbier; minor types include Lambic, Berliner Weisse and Gose", ImgPath = "/Images/Wheat-Beer.png", Style = "Wheat" },
                        new { CategoryId = 4, DetailDescription = "Strong beers have a special place in many people's hearts, primarily because they involve the delicious fizz of beer with a very powerful alcoholic punch. They get you blitzed without requiring six or more of them per sitting, and that makes them amazing. ", ImgPath = "/Images/SnakeVenom.png", Style = "High ABV" }
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
                        new { UserReviewId = 1, BeerId = 1, UserRating = 4, UserText = "This rocks...nuff said ya dig it." },
                        new { UserReviewId = 2, BeerId = 1, UserRating = 5, UserText = "A very creative beer with a unique, beautiful, and delicious hops profile. Nice dry, balanced base beer with enough malt backbone to support but not crowd the hops, interesting hops profile that showcases both piney, resinous, dank flavors with classic American citrus notes and tropical fruit hops flavors, and a very clean fermentation profile to boot. Extremely drinkable thanks to lower bitterness but no doubt about it, the hops are the belle of the ball. Buy by the case—it’s an excellent example of the style." },
                        new { UserReviewId = 3, BeerId = 2, UserRating = 3, UserText = "Caramel background, the smallest hint of tropical fruit, lots of pine and citrus. A good example of what it is, but what it is is still a boring, rather one-note IPA." },
                        new { UserReviewId = 4, BeerId = 2, UserRating = 4, UserText = "Slammed me like a hibbidy bibiddy hop" },
                        new { UserReviewId = 5, BeerId = 3, UserRating = 1, UserText = "So that's what a hobo tastes like..." },
                        new { UserReviewId = 6, BeerId = 3, UserRating = 3, UserText = "This is a full-bodied rendition of the style with carbonation at the lower end of the style spectrum, while the alcohol content was quite evident -- contributing to this beer's warming presence. Very true to form, this Double IPA stands tall and should be considered for consumption as a fine example of the style." }
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
