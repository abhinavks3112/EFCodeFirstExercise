namespace EFCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVideosAndGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Videos(Name, ReleaseDate) VALUES ('Forest Gump', '2000/09/22')");
            Sql("INSERT INTO Videos(Name, ReleaseDate) VALUES ('Toy Story', '2004/05/02')");
            Sql("INSERT INTO Videos(Name, ReleaseDate) VALUES ('The Man From Earth', '1997/10/08')");
            Sql("INSERT INTO Videos(Name, ReleaseDate) VALUES ('The Witcher', '2019/12/15')");

            Sql("INSERT INTO Genres(Id, Name) VALUES (1, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2, 'Animation')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3, 'Sci Fi')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4, 'Fantasy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (5, 'Comedy')");

            Sql("INSERT INTO VideoGenres(Genre_Id, Video_Id) SELECT 1, Id FROM Videos WHERE Name = 'Forest Gump'");
            Sql("INSERT INTO VideoGenres(Genre_Id, Video_Id) SELECT 2, Id FROM Videos WHERE Name = 'Toy Story'");
            Sql("INSERT INTO VideoGenres(Genre_Id, Video_Id) SELECT 5, Id FROM Videos WHERE Name = 'Toy Story'");
            Sql("INSERT INTO VideoGenres(Genre_Id, Video_Id) SELECT 1, Id FROM Videos WHERE Name = 'The Man From Earth'");
            Sql("INSERT INTO VideoGenres(Genre_Id, Video_Id) SELECT 4, Id FROM Videos WHERE Name = 'The Witcher'");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Videos WHERE Name = 'Forest Gump'");
            Sql("DELETE FROM Videos WHERE Name = 'Toy Story'");
            Sql("DELETE FROM Videos WHERE Name = 'The Man From Earth'");
            Sql("DELETE FROM Videos WHERE Name = 'The Witcher'");

            Sql("DELETE FROM Genres WHERE Name = 'Drama'");
            Sql("DELETE FROM Genres WHERE Name = 'Animation'");
            Sql("DELETE FROM Genres WHERE Name = 'Sci Fi'");
            Sql("DELETE FROM Genres WHERE Name = 'Fantasy'");
            Sql("DELETE FROM Genres WHERE Name = 'Comedy'");

            Sql("DELETE FROM VideoGenres WHERE Genre_Id IN (1,2,3,4,5)");
        }
    }
}
