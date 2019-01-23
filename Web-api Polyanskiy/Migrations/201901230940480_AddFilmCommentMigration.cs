namespace Web_api_Polyanskiy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilmCommentMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FilmId = c.Int(nullable: false),
                        FilmName = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.FilmId);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Director = c.String(),
                        Year = c.Int(nullable: false),
                        Genre = c.String(),
                        Country = c.String(),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
            DropTable("dbo.Comments");
        }
    }
}
