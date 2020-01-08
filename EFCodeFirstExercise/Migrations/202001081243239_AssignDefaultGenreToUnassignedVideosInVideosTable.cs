namespace EFCodeFirstExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignDefaultGenreToUnassignedVideosInVideosTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Videos SET Genre_Id = 1 WHERE Genre_Id IS NULL");
        }
        
        public override void Down()
        {
            Sql("UPDATE Videos SET Genre_Id = NULL WHERE Genre_Id = 1");
        }
    }
}
