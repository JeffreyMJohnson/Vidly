namespace Vidly_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Comedy')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Family')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Science-Fiction')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Horror')");
            Sql("INSERT INTO dbo.Genres (Name) VALUES ('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
