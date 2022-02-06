using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MovieCharactersAPI.Models
{
    public class MediaDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Franchise> Franchises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///CHARACTERS
            modelBuilder.Entity<Character>().HasData(new Character
            {
                CharacterId = 1,
                Name = "James Bond",
                Alias = "007",
                Gender = "Male",           
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                CharacterId = 2,
                Name = "Tony Stark",
                Alias = "Iron Man",
                Gender = "Male",
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                CharacterId = 3,
                Name = "Carol Danvers",
                Alias = "Captain Marvel",
                Gender = "Female",
            });
            modelBuilder.Entity<Character>().HasData(new Character
            {
                CharacterId = 4,
                Name = "Anakin Skywalker",
                Alias = "Darth Vader",
                Gender = "Male",
            });

            ///MOVIES
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 1,
                Title = "No Time To Die",
                Genre = "Action",
                ReleaseYear = "2021",
                Director = "Cary Joji Fukunaga",
                Trailer = "https://www.youtube.com/watch?v=N_gD9-Oa0fg",
                FranchiseId = 1,

            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 2,
                Title = "Infinity War",
                Genre = "Action",
                ReleaseYear = "2018",
                Director = "Russo",
                Trailer = "https://www.youtube.com/watch?v=6ZfuNTqbHE8",
                FranchiseId = 2,
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 3,
                Title = "Endgame",
                Genre = "Action",
                ReleaseYear = "2019",
                Director = "Russo",
                Trailer = "https://www.youtube.com/watch?v=TcMBFSGVi1c",
                FranchiseId = 2,
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 4 ,
                Title = "The Empire Strikes Back",
                Genre = "Action",
                ReleaseYear = "1980",
                Director = "Irvin Kershner",
                Trailer = "https://www.youtube.com/watch?v=JNwNXF9Y6kY",
                FranchiseId = 3,
            });

            ///FRANCHISES
            modelBuilder.Entity<Franchise>().HasData(new Franchise
            {
                FranchiseId = 1,
                Name =  "James Bond",
                Description = ""
            });
            modelBuilder.Entity<Franchise>().HasData(new Franchise
            {
                FranchiseId = 2,
                Name = "Marvel Cinematic Universe",
                Description = ""
            });
            modelBuilder.Entity<Franchise>().HasData(new Franchise
            {
                FranchiseId = 3,
                Name = "Star Wars",
                Description = ""
            });

            modelBuilder.Entity<Movie>()
                .HasMany(p => p.Characters)
                .WithMany(m => m.Movies)
                .UsingEntity<Dictionary<string, object>>(
                    "CharacterMovie",
                    r => r.HasOne<Character>().WithMany().HasForeignKey("CharacterId"),
                    l => l.HasOne<Movie>().WithMany().HasForeignKey("MovieId"),
                    je =>
                    {
                        je.HasKey("MovieId", "CharacterId");
                        je.HasData(
                            new { MovieId = 1, CharacterId = 1 },
                            new { MovieId = 2, CharacterId = 2 },
                            new { MovieId = 2, CharacterId = 3 },
                            new { MovieId = 3, CharacterId = 2 },
                            new { MovieId = 3, CharacterId = 3 },
                            new { MovieId = 4, CharacterId = 4 }
                        );
                    });

        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-MJQMMB2\\SQLEXPRESS; Initial Catalog=MediaCodeFirstDB; Integrated Security=True");
        }
    }
}