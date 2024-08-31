﻿// <auto-generated />
using System;
using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shared.DbModels.AnswerModel", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnswerId"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            Answer = "Alexstrasza",
                            IsCorrect = true,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 2,
                            Answer = "Ysera",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 3,
                            Answer = "Nozdormu",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 4,
                            Answer = "Malygos",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 5,
                            Answer = "Kel'Thuzad",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 6,
                            Answer = "Anub'Rekhan",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 7,
                            Answer = "Sapphiron",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 8,
                            Answer = "Patchwerk",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 9,
                            Answer = "Ashe",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 10,
                            Answer = "Twisted Fate",
                            IsCorrect = true,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 11,
                            Answer = "Alistar",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 12,
                            Answer = "Kayle",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 13,
                            Answer = "B.F. Sword",
                            IsCorrect = true,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 14,
                            Answer = "Long Sword",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 15,
                            Answer = "Pickaxe",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 16,
                            Answer = "Dagger",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 17,
                            Answer = "Lucario",
                            IsCorrect = true,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 18,
                            Answer = "Pikachu",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 19,
                            Answer = "Mewtwo",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 20,
                            Answer = "Charizard",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 21,
                            Answer = "Moon Stone",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 22,
                            Answer = "Friendship during nighttime",
                            IsCorrect = true,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 23,
                            Answer = "Thunder Stone",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 24,
                            Answer = "Dusk Stone",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 25,
                            Answer = "Dust II",
                            IsCorrect = true,
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 26,
                            Answer = "Mirage",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 27,
                            Answer = "Inferno",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 28,
                            Answer = "Nuke",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 29,
                            Answer = "40 seconds",
                            IsCorrect = true,
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 30,
                            Answer = "35 seconds",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 31,
                            Answer = "45 seconds",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 32,
                            Answer = "30 seconds",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 33,
                            Answer = "Super Mario World",
                            IsCorrect = true,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 34,
                            Answer = "Super Mario Bros. 3",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 35,
                            Answer = "Super Mario 64",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 36,
                            Answer = "Super Mario Sunshine",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 37,
                            Answer = "Yoshi",
                            IsCorrect = true,
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 38,
                            Answer = "Bowser",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 39,
                            Answer = "Toad",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 40,
                            Answer = "Luigi",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 41,
                            Answer = "Ocarina of Time",
                            IsCorrect = true,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 42,
                            Answer = "Majora's Mask",
                            IsCorrect = false,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 43,
                            Answer = "The Wind Waker",
                            IsCorrect = false,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 44,
                            Answer = "Twilight Princess",
                            IsCorrect = false,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 45,
                            Answer = "King of Red Lions",
                            IsCorrect = true,
                            QuestionId = 12
                        },
                        new
                        {
                            AnswerId = 46,
                            Answer = "Epona",
                            IsCorrect = false,
                            QuestionId = 12
                        },
                        new
                        {
                            AnswerId = 47,
                            Answer = "Tetra",
                            IsCorrect = false,
                            QuestionId = 12
                        },
                        new
                        {
                            AnswerId = 48,
                            Answer = "Phantom",
                            IsCorrect = false,
                            QuestionId = 12
                        });
                });

            modelBuilder.Entity("Shared.DbModels.EmailModel", b =>
                {
                    b.Property<int>("EmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmailId"));

                    b.Property<DateTime>("DateLastSent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailId");

                    b.ToTable("EmailModels");

                    b.HasData(
                        new
                        {
                            EmailId = 1,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(733),

                            Email = "Maxtharn@gmail.com"
                        },
                        new
                        {
                            EmailId = 2,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(778),

                            Email = "Nckandero@gmail.com"
                        },
                        new
                        {
                            EmailId = 3,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(780),

                            Email = "emil.aberg@live.com"
                        },
                        new
                        {
                            EmailId = 4,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(781),

                            Email = "e.johannesnilsson@gmail.com"
                        },
                        new
                        {
                            EmailId = 5,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(783),

                            Email = "emmzaa1337@gmail.com"
                        },
                        new
                        {
                            EmailId = 6,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(784),

                            Email = "Din@Son.lol"
                        },
                        new
                        {
                            EmailId = 7,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(786),

                            Email = "Din@Kusin.lol"
                        },
                        new
                        {
                            EmailId = 8,

                            DateLastSent = new DateTime(2024, 8, 31, 15, 25, 40, 565, DateTimeKind.Local).AddTicks(787),

                            Email = "oscar.sommerfors@gmail.com"
                        });
                });

            modelBuilder.Entity("Shared.DbModels.MetaTagModel", b =>
                {
                    b.Property<int>("MetaTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MetaTagId"));

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MetaTagId");

                    b.ToTable("MetaTags");

                    b.HasData(
                        new
                        {
                            MetaTagId = 1,
                            TagName = "World of Warcraft"
                        },
                        new
                        {
                            MetaTagId = 2,
                            TagName = "League of Legends"
                        },
                        new
                        {
                            MetaTagId = 3,
                            TagName = "Pokemon"
                        },
                        new
                        {
                            MetaTagId = 4,
                            TagName = "Counter-Strike"
                        },
                        new
                        {
                            MetaTagId = 5,
                            TagName = "Super Mario"
                        },
                        new
                        {
                            MetaTagId = 6,
                            TagName = "The Legend of Zelda"
                        });
                });

            modelBuilder.Entity("Shared.DbModels.QuestionMetaTag", b =>
                {
                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("MetaTagId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId", "MetaTagId");

                    b.HasIndex("MetaTagId");

                    b.ToTable("QuestionMetaTags");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            MetaTagId = 1
                        },
                        new
                        {
                            QuestionId = 2,
                            MetaTagId = 1
                        },
                        new
                        {
                            QuestionId = 2,
                            MetaTagId = 2
                        },
                        new
                        {
                            QuestionId = 3,
                            MetaTagId = 2
                        },
                        new
                        {
                            QuestionId = 3,
                            MetaTagId = 3
                        },
                        new
                        {
                            QuestionId = 4,
                            MetaTagId = 3
                        },
                        new
                        {
                            QuestionId = 4,
                            MetaTagId = 4
                        },
                        new
                        {
                            QuestionId = 5,
                            MetaTagId = 4
                        },
                        new
                        {
                            QuestionId = 5,
                            MetaTagId = 5
                        },
                        new
                        {
                            QuestionId = 6,
                            MetaTagId = 5
                        },
                        new
                        {
                            QuestionId = 6,
                            MetaTagId = 6
                        },
                        new
                        {
                            QuestionId = 7,
                            MetaTagId = 6
                        });
                });

            modelBuilder.Entity("Shared.DbModels.QuestionModel", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            Question = "Which dragon aspect was originally charged with protecting life on Azeroth?"
                        },
                        new
                        {
                            QuestionId = 2,
                            Question = "Who was the final boss of the original Naxxramas raid?"
                        },
                        new
                        {
                            QuestionId = 3,
                            Question = "Which champion was the first to be released in League of Legends?"
                        },
                        new
                        {
                            QuestionId = 4,
                            Question = "What is the name of the item that builds into Infinity Edge?"
                        },
                        new
                        {
                            QuestionId = 5,
                            Question = "Which Pokémon is known as the 'Aura Pokémon'?"
                        },
                        new
                        {
                            QuestionId = 6,
                            Question = "What item is used to evolve Eevee into Umbreon?"
                        },
                        new
                        {
                            QuestionId = 7,
                            Question = "Which map features the iconic AWP sniper duel at Long A?"
                        },
                        new
                        {
                            QuestionId = 8,
                            Question = "What is the default bomb timer in Counter-Strike: Global Offensive?"
                        },
                        new
                        {
                            QuestionId = 9,
                            Question = "Which game introduced Mario's ability to fly with the Cape Feather?"
                        },
                        new
                        {
                            QuestionId = 10,
                            Question = "What is the name of Mario’s dinosaur companion?"
                        },
                        new
                        {
                            QuestionId = 11,
                            Question = "Which Zelda game features the 'Temple of Time' as a central location?"
                        },
                        new
                        {
                            QuestionId = 12,
                            Question = "What is the name of Link’s talking boat in The Wind Waker?"
                        });
                });

            modelBuilder.Entity("Shared.DbModels.QuizModel", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuizId"));

                    b.Property<string>("QuizName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizId");

                    b.ToTable("QuizModels");

                    b.HasData(
                        new
                        {
                            QuizId = 1,
                            QuizName = "Gaming Quiz"
                        },
                        new
                        {
                            QuizId = 2,
                            QuizName = "Mixed Quiz"
                        });
                });

            modelBuilder.Entity("Shared.DbModels.QuizQuestion", b =>
                {
                    b.Property<int>("QuizId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("QuizId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuizQuestions");

                    b.HasData(
                        new
                        {
                            QuizId = 1,
                            QuestionId = 1
                        },
                        new
                        {
                            QuizId = 1,
                            QuestionId = 2
                        },
                        new
                        {
                            QuizId = 1,
                            QuestionId = 3
                        },
                        new
                        {
                            QuizId = 1,
                            QuestionId = 4
                        },
                        new
                        {
                            QuizId = 1,
                            QuestionId = 5
                        },
                        new
                        {
                            QuizId = 1,
                            QuestionId = 6
                        },
                        new
                        {
                            QuizId = 2,
                            QuestionId = 7
                        },
                        new
                        {
                            QuizId = 2,
                            QuestionId = 8
                        },
                        new
                        {
                            QuizId = 2,
                            QuestionId = 9
                        },
                        new
                        {
                            QuizId = 2,
                            QuestionId = 10
                        },
                        new
                        {
                            QuizId = 2,
                            QuestionId = 11
                        },
                        new
                        {
                            QuizId = 2,
                            QuestionId = 12
                        });
                });

            modelBuilder.Entity("Shared.DbModels.AnswerModel", b =>
                {
                    b.HasOne("Shared.DbModels.QuestionModel", "QuestionModel")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionModel");
                });

            modelBuilder.Entity("Shared.DbModels.QuestionMetaTag", b =>
                {
                    b.HasOne("Shared.DbModels.MetaTagModel", "MetaTag")
                        .WithMany("QuestionMetaTags")
                        .HasForeignKey("MetaTagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.DbModels.QuestionModel", "Question")
                        .WithMany("QuestionMetaTags")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MetaTag");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Shared.DbModels.QuizQuestion", b =>
                {
                    b.HasOne("Shared.DbModels.QuestionModel", "Question")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shared.DbModels.QuizModel", "Quiz")
                        .WithMany("QuizQuestions")
                        .HasForeignKey("QuizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Quiz");
                });

            modelBuilder.Entity("Shared.DbModels.MetaTagModel", b =>
                {
                    b.Navigation("QuestionMetaTags");
                });

            modelBuilder.Entity("Shared.DbModels.QuestionModel", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("QuestionMetaTags");

                    b.Navigation("QuizQuestions");
                });

            modelBuilder.Entity("Shared.DbModels.QuizModel", b =>
                {
                    b.Navigation("QuizQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
