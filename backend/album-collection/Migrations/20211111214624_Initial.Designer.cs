﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using album_collection;

namespace album_collection.Migrations
{
    [DbContext(typeof(AlbumCollectionContext))]
    [Migration("20211111214624_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 2,
                            Genre = "M-POP (Mix-Mandarin-Pop)",
                            RecordLabel = "Zhang Yixing Studio",
                            ReleaseYear = 2020,
                            Title = "蓮 (Lit)"
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 1,
                            Genre = "Hip-Hop, R&B",
                            RecordLabel = "Primary Wave Music",
                            ReleaseYear = 2007,
                            Title = "Just like You"
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 4,
                            Genre = "Blues Rock, Space Rock",
                            RecordLabel = "eOne",
                            ReleaseYear = 2015,
                            Title = "Black Holes"
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 3,
                            Genre = "Post-Metal",
                            RecordLabel = "Silver Cord Studio",
                            ReleaseYear = 2016,
                            Title = "Magma"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistLabel = "Geffen Records",
                            Name = "Keyshia Cole"
                        },
                        new
                        {
                            Id = 2,
                            ArtistLabel = "SM Entertainment",
                            Name = "Lay Zhang"
                        },
                        new
                        {
                            Id = 3,
                            ArtistLabel = "RoadRunner Records",
                            Name = "Gojira"
                        },
                        new
                        {
                            Id = 4,
                            ArtistLabel = "Entertainment One",
                            Name = "The Blue Stones"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 4,
                            Content = "Sample Review for now",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewerName = "Dan F."
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 3,
                            Content = "Sample Review for now",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewerName = "Eliza L."
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 2,
                            Content = "Sample Review for now",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewerName = "Ziyah F."
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 1,
                            Content = "Sample Review for now",
                            ReviewDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewerName = "Crys D."
                        });
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 3,
                            Title = "The Hard Part"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 4,
                            Title = "Silvera"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 1,
                            Title = "夜 (Late Night)"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 2,
                            Title = "Didn't I Tell You (featuring Too $hort)"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.HasOne("album_collection.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("album_collection.Models.Review", b =>
                {
                    b.HasOne("album_collection.Models.Album", null)
                        .WithMany("Reviews")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.HasOne("album_collection.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Navigation("Reviews");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
