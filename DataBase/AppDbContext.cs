﻿using Microsoft.EntityFrameworkCore;
using Shared.DbModels;

namespace DataBase
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<MetaTagModel> MetaTags { get; set; }

        public DbSet<QuizModel> QuizModels { get; set; }

        public DbSet<EmailModel> EmailModels { get; set; }

        public DbSet<QuestionMetaTag> QuestionMetaTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Meta Tags
            modelBuilder.Entity<MetaTagModel>().HasData(
                new MetaTagModel { MetaTagId = 1, TagName = "World of Warcraft" },
                new MetaTagModel { MetaTagId = 2, TagName = "League of Legends" },
                new MetaTagModel { MetaTagId = 3, TagName = "Pokemon" },
                new MetaTagModel { MetaTagId = 4, TagName = "Counter-Strike" },
                new MetaTagModel { MetaTagId = 5, TagName = "Super Mario" },
                new MetaTagModel { MetaTagId = 6, TagName = "The Legend of Zelda" }
            );

            // Seed Quizzes
            modelBuilder.Entity<QuizModel>().HasData(
                new QuizModel { QuizModelId = 1, QuizName = "Gaming Quiz" },
                new QuizModel { QuizModelId = 2, QuizName = "Mixed Quiz" }

            );

            // Seed Questions
            modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel { QuestionId = 1, QuizModelId = 1, Question = "Which dragon aspect was originally charged with protecting life on Azeroth?" },
                new QuestionModel { QuestionId = 2, QuizModelId = 1, Question = "Who was the final boss of the original Naxxramas raid?" },
                new QuestionModel { QuestionId = 3, QuizModelId = 1, Question = "Which champion was the first to be released in League of Legends?" },
                new QuestionModel { QuestionId = 4, QuizModelId = 1, Question = "What is the name of the item that builds into Infinity Edge?" },
                new QuestionModel { QuestionId = 5, QuizModelId = 1, Question = "Which Pokémon is known as the 'Aura Pokémon'?" },
                new QuestionModel { QuestionId = 6, QuizModelId = 1, Question = "What item is used to evolve Eevee into Umbreon?" },
                new QuestionModel { QuestionId = 7, QuizModelId = 1, Question = "Which map features the iconic AWP sniper duel at Long A?" },
                new QuestionModel { QuestionId = 8, QuizModelId = 1, Question = "What is the default bomb timer in Counter-Strike: Global Offensive?" },
                new QuestionModel { QuestionId = 9, QuizModelId = 1, Question = "Which game introduced Mario's ability to fly with the Cape Feather?" },
                new QuestionModel { QuestionId = 10, QuizModelId = 1, Question = "What is the name of Mario’s dinosaur companion?" },
                new QuestionModel { QuestionId = 11, QuizModelId = 1, Question = "Which Zelda game features the 'Temple of Time' as a central location?" },
                new QuestionModel { QuestionId = 12, QuizModelId = 1, Question = "What is the name of Link’s talking boat in The Wind Waker?" }
            );

            // Seed Answers
            modelBuilder.Entity<AnswerModel>().HasData(
                // World of Warcraft Answers
                new AnswerModel { AnswerId = 1, QuestionId = 1, IsCorrect = true, Answer = "Alexstrasza" },
                new AnswerModel { AnswerId = 2, QuestionId = 1, IsCorrect = false, Answer = "Ysera" },
                new AnswerModel { AnswerId = 3, QuestionId = 1, IsCorrect = false, Answer = "Nozdormu" },
                new AnswerModel { AnswerId = 4, QuestionId = 1, IsCorrect = false, Answer = "Malygos" },

                new AnswerModel { AnswerId = 5, QuestionId = 2, IsCorrect = true, Answer = "Kel'Thuzad" },
                new AnswerModel { AnswerId = 6, QuestionId = 2, IsCorrect = false, Answer = "Anub'Rekhan" },
                new AnswerModel { AnswerId = 7, QuestionId = 2, IsCorrect = false, Answer = "Sapphiron" },
                new AnswerModel { AnswerId = 8, QuestionId = 2, IsCorrect = false, Answer = "Patchwerk" },

                // League of Legends Answers
                new AnswerModel { AnswerId = 9, QuestionId = 3, IsCorrect = false, Answer = "Ashe" },
                new AnswerModel { AnswerId = 10, QuestionId = 3, IsCorrect = true, Answer = "Twisted Fate" },
                new AnswerModel { AnswerId = 11, QuestionId = 3, IsCorrect = false, Answer = "Alistar" },
                new AnswerModel { AnswerId = 12, QuestionId = 3, IsCorrect = false, Answer = "Kayle" },

                new AnswerModel { AnswerId = 13, QuestionId = 4, IsCorrect = true, Answer = "B.F. Sword" },
                new AnswerModel { AnswerId = 14, QuestionId = 4, IsCorrect = false, Answer = "Long Sword" },
                new AnswerModel { AnswerId = 15, QuestionId = 4, IsCorrect = false, Answer = "Pickaxe" },
                new AnswerModel { AnswerId = 16, QuestionId = 4, IsCorrect = false, Answer = "Dagger" },

                // Pokemon Answers
                new AnswerModel { AnswerId = 17, QuestionId = 5, IsCorrect = true, Answer = "Lucario" },
                new AnswerModel { AnswerId = 18, QuestionId = 5, IsCorrect = false, Answer = "Pikachu" },
                new AnswerModel { AnswerId = 19, QuestionId = 5, IsCorrect = false, Answer = "Mewtwo" },
                new AnswerModel { AnswerId = 20, QuestionId = 5, IsCorrect = false, Answer = "Charizard" },

                new AnswerModel { AnswerId = 21, QuestionId = 6, IsCorrect = false, Answer = "Moon Stone" },
                new AnswerModel { AnswerId = 22, QuestionId = 6, IsCorrect = true, Answer = "Friendship during nighttime" },
                new AnswerModel { AnswerId = 23, QuestionId = 6, IsCorrect = false, Answer = "Thunder Stone" },
                new AnswerModel { AnswerId = 24, QuestionId = 6, IsCorrect = false, Answer = "Dusk Stone" },

                // Counter-Strike Answers
                new AnswerModel { AnswerId = 25, QuestionId = 7, IsCorrect = true, Answer = "Dust II" },
                new AnswerModel { AnswerId = 26, QuestionId = 7, IsCorrect = false, Answer = "Mirage" },
                new AnswerModel { AnswerId = 27, QuestionId = 7, IsCorrect = false, Answer = "Inferno" },
                new AnswerModel { AnswerId = 28, QuestionId = 7, IsCorrect = false, Answer = "Nuke" },

                new AnswerModel { AnswerId = 29, QuestionId = 8, IsCorrect = true, Answer = "40 seconds" },
                new AnswerModel { AnswerId = 30, QuestionId = 8, IsCorrect = false, Answer = "35 seconds" },
                new AnswerModel { AnswerId = 31, QuestionId = 8, IsCorrect = false, Answer = "45 seconds" },
                new AnswerModel { AnswerId = 32, QuestionId = 8, IsCorrect = false, Answer = "30 seconds" },

                // Super Mario Answers
                new AnswerModel { AnswerId = 33, QuestionId = 9, IsCorrect = true, Answer = "Super Mario World" },
                new AnswerModel { AnswerId = 34, QuestionId = 9, IsCorrect = false, Answer = "Super Mario Bros. 3" },
                new AnswerModel { AnswerId = 35, QuestionId = 9, IsCorrect = false, Answer = "Super Mario 64" },
                new AnswerModel { AnswerId = 36, QuestionId = 9, IsCorrect = false, Answer = "Super Mario Sunshine" },

                new AnswerModel { AnswerId = 37, QuestionId = 10, IsCorrect = true, Answer = "Yoshi" },
                new AnswerModel { AnswerId = 38, QuestionId = 10, IsCorrect = false, Answer = "Bowser" },
                new AnswerModel { AnswerId = 39, QuestionId = 10, IsCorrect = false, Answer = "Toad" },
                new AnswerModel { AnswerId = 40, QuestionId = 10, IsCorrect = false, Answer = "Luigi" },

                // The Legend of Zelda Answers
                new AnswerModel { AnswerId = 41, QuestionId = 11, IsCorrect = true, Answer = "Ocarina of Time" },
                new AnswerModel { AnswerId = 42, QuestionId = 11, IsCorrect = false, Answer = "Majora's Mask" },
                new AnswerModel { AnswerId = 43, QuestionId = 11, IsCorrect = false, Answer = "The Wind Waker" },
                new AnswerModel { AnswerId = 44, QuestionId = 11, IsCorrect = false, Answer = "Twilight Princess" },

                new AnswerModel { AnswerId = 45, QuestionId = 12, IsCorrect = true, Answer = "King of Red Lions" },
                new AnswerModel { AnswerId = 46, QuestionId = 12, IsCorrect = false, Answer = "Epona" },
                new AnswerModel { AnswerId = 47, QuestionId = 12, IsCorrect = false, Answer = "Tetra" },
                new AnswerModel { AnswerId = 48, QuestionId = 12, IsCorrect = false, Answer = "Phantom" }
            );

            // Seed QuestionMetaTags
            modelBuilder.Entity<QuestionMetaTag>().HasData(
                new QuestionMetaTag { QuestionId = 1, MetaTagId = 1 },
                new QuestionMetaTag { QuestionId = 2, MetaTagId = 1 },
                new QuestionMetaTag { QuestionId = 3, MetaTagId = 2 },
                new QuestionMetaTag { QuestionId = 4, MetaTagId = 2 },
                new QuestionMetaTag { QuestionId = 5, MetaTagId = 3 },
                new QuestionMetaTag { QuestionId = 6, MetaTagId = 3 },
                new QuestionMetaTag { QuestionId = 7, MetaTagId = 4 },
                new QuestionMetaTag { QuestionId = 8, MetaTagId = 4 },
                new QuestionMetaTag { QuestionId = 9, MetaTagId = 5 },
                new QuestionMetaTag { QuestionId = 10, MetaTagId = 5 },
                new QuestionMetaTag { QuestionId = 11, MetaTagId = 6 },
                new QuestionMetaTag { QuestionId = 12, MetaTagId = 6 }
            );

        }
    }
}
