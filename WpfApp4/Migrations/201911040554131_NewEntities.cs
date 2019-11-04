namespace WpfApp4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Charters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.ReaderCards",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Readers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReaderCards", "Id", "dbo.Readers");
            DropForeignKey("dbo.Charters", "Book_Id", "dbo.Books");
            DropIndex("dbo.ReaderCards", new[] { "Id" });
            DropIndex("dbo.Charters", new[] { "Book_Id" });
            DropTable("dbo.ReaderCards");
            DropTable("dbo.Charters");
        }
    }
}
