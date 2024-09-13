using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Seededmoredataforquizzes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 13, 11, 12, 22, 46, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9,
                column: "Image",
                value: "../src/assets/images/Firelands.jpg");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Test your knowledge of the World of Warcraft universe with this engaging quiz! This quiz contains 10 questions that cover various aspects of the game, including its history, characters, locations, and gameplay mechanics. Whether you're a seasoned WoW player or new to the game, this quiz will challenge your understanding and provide a fun way to revisit the world of Azeroth.", "World of Warcraft (WoW) is a massively multiplayer online role-playing game (MMORPG) developed by Blizzard Entertainment. Set in the fantasy world of Azeroth, players create characters and embark on epic quests, battling monsters, exploring dungeons, and engaging in player-versus-player combat. The game is known for its rich lore, expansive world, and vibrant community. Players can choose from various races and classes, each with unique abilities and storylines, making every adventure unique." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Test your League of Legends knowledge with this thrilling quiz! Featuring 15 questions, this quiz explores the game's champions, strategies, lore, and iconic moments. Whether you're a veteran player or just starting, this quiz will challenge your understanding of the Rift and the legends within it.", "League of Legends is a popular multiplayer online battle arena (MOBA) game developed by Riot Games. Players control champions with unique abilities and work together in teams to destroy the enemy's Nexus. The game features a diverse roster of characters, strategic gameplay, and a vibrant esports scene, making it a favorite among competitive gamers worldwide." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Dive into the world of Pokémon with this engaging quiz! This 15-question challenge covers various aspects of the game, including Pokémon types, evolutions, iconic characters, and battle mechanics. Test your skills and see if you can become a Pokémon Master!", "Pokémon is a beloved role-playing game series developed by Game Freak and published by Nintendo. Players capture, train, and battle Pokémon creatures, aiming to become the ultimate Pokémon Trainer. With various regions, hundreds of species, and engaging turn-based battles, Pokémon remains one of the most popular franchises in gaming history." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Show off your Counter-Strike expertise with this intense quiz! Featuring 15 questions, this challenge tests your knowledge of maps, weapons, strategies, and key moments in Counter-Strike history. Whether you're a casual player or a seasoned pro, this quiz will keep you on your toes.", "Counter-Strike is a tactical first-person shooter developed by Valve Corporation. The game pits two teams—Terrorists and Counter-Terrorists—against each other in objective-based gameplay. Known for its strategic depth, skillful shooting mechanics, and competitive atmosphere, Counter-Strike remains a cornerstone of the esports world." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Take on the Super Mario quiz and test your knowledge of the Mushroom Kingdom! This 15-question challenge covers the series' characters, power-ups, levels, and hidden secrets. Whether you're a lifelong fan or new to Mario's adventures, this quiz is sure to entertain.", "Super Mario is a classic platformer series created by Nintendo. Players control Mario, a heroic plumber who navigates colorful levels, defeats enemies, and rescues Princess Peach from the villain Bowser. Known for its iconic gameplay, catchy music, and memorable characters, Super Mario is a staple of gaming culture." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Test your knowledge of The Legend of Zelda with this exciting quiz! Featuring 10 questions, this challenge delves into the game's lore, characters, dungeons, and memorable moments. Whether you're a seasoned adventurer or just discovering Hyrule, this quiz will test your heroic spirit.", "The Legend of Zelda is an action-adventure series developed by Nintendo. Players control Link, a hero who embarks on epic quests to save Princess Zelda and the kingdom of Hyrule. With its open-world exploration, challenging puzzles, and rich storytelling, Zelda remains one of gaming's most beloved franchises." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Dive into a challenge that spans multiple gaming universes! With 10 questions covering World of Warcraft, League of Legends, Pokémon, Counter-Strike, Super Mario, and The Legend of Zelda, this quiz will put your gaming knowledge to the ultimate test.", "Test your knowledge across some of the most iconic games ever made, including World of Warcraft, League of Legends, Pokémon, Super Mario, Counter-Strike, and The Legend of Zelda. This mixed quiz brings together questions from each game, making it perfect for fans of all genres." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 1,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 2,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 3,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 4,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 5,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 6,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 7,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "Emails",
                keyColumn: "EmailId",
                keyValue: 8,
                column: "DateLastSent",
                value: new DateTime(2024, 9, 11, 14, 50, 41, 172, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionId",
                keyValue: 9,
                column: "Image",
                value: "../src/assets/images/Fireland.jpg");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 1,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Dive into the rich lore, epic raids, and character classes of Azeroth as you tackle this World of Warcraft challenge.", "An expansive MMORPG set in a fantasy world where players create characters, complete quests, and battle in epic raids." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 2,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Prove your knowledge of champions, game mechanics, and legendary plays from the Summoner's Rift in this thrilling League of Legends quiz.", "A fast-paced multiplayer online battle arena (MOBA) where two teams of champions face off to destroy each other's Nexus." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 3,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Test your skills in identifying Pokémon, their types, evolutions, and battle strategies in this ultimate Pokémon quiz.", "A beloved RPG where players capture, train, and battle creatures called Pokémon, striving to become the ultimate Pokémon Master." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 4,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Show off your tactical knowledge, map awareness, and weapon expertise in this intense Counter-Strike quiz.", "A tactical first-person shooter that pits teams of terrorists and counter-terrorists against each other in intense, strategic combat." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 5,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Navigate through iconic levels, power-ups, and memorable characters from the Mario universe in this nostalgic Super Mario quiz.", "A classic platformer where Mario, a heroic plumber, navigates through levels to rescue Princess Peach from Bowser." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 6,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Challenge your understanding of legendary quests, dungeons, and characters from the timeless world of The Legend of Zelda.", "An action-adventure series featuring Link, a hero who explores dungeons, solves puzzles, and battles foes to save the kingdom of Hyrule." });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "QuizId",
                keyValue: 7,
                columns: new[] { "QuizChallenge", "QuizDescription" },
                values: new object[] { "Challenge yourself with a mixed quiz of the games, World of Warcraft, League of Legends, Pokemón, Counter-Strike, Super-Mario and The Legend of Zelda", "A mixed quiz with questions from the beloved games, World of Warcraft, League of Legends, Pokemon, Super Mario, Counter-Strike and The Legend of Zelda" });
        }
    }
}
