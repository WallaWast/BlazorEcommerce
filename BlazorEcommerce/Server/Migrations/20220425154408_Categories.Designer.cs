﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220425154408_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Games",
                            Url = "games"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Music",
                            Url = "music"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Price = 9.99m,
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Price = 7.99m,
                            Title = "Ready Player One"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Console Wars: Sega, Nintendo, and the Battle That Defined a Generation is a 2014 non-fiction novel written by Blake J. Harris. It follows businessman Tom Kalinske in his venture as CEO of video game company Sega of America from 1990 to 1996, and details the history of the fierce business competition between Sega and Nintendo throughout the 1990s as well as the internal conflicts that took place between Sega of America and its Japanese parent company, Sega Enterprise. Harris wrote the book in the style of a novel by compiling several interviews with people who were involved with the events, using the information gathered to create a dramatic interpretation of the events. A documentary of the book directed by Harris and Jonah Tulis was released on CBS All Access on September 23, 2020. A miniseries adaptation is in development with Seth Rogen and Evan Goldberg executive producing with Jordan Vogt-Roberts directing.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b7/Console_Wars_Book_Cover.jpeg",
                            Price = 35.99m,
                            Title = "Console Wars"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "The Legend of Zelda: Breath of the Wild – Creating a Champion[a] is a companion art book to Nintendo's 2017 video game The Legend of Zelda: Breath of the Wild. It was published in English by Dark Horse Comics on 20 November 2018 and is a localisation of a book titled Master Works that was published by Nintendo in Japan. It presents official illustrations and concept art from the game alongside development notes and also documents the fictional history of Hyrule presented in the game. The book was released as a standard edition with a white cover, a 'Hero's Edition' featuring a blue cloth slip case and a 'Champion's Edition' collector's box with a leather case.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/88/Tloz_breath_of_the_wild_creating_a_champion_standard_english_cover.jpg",
                            Price = 12.99m,
                            Title = "The Legend of Zelda: Breath of the Wild – Creating a Champion"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}