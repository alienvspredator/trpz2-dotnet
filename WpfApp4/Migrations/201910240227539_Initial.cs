namespace WpfApp4.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    ReleaseDate = c.DateTime(nullable: false),
                    Reader_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Reader_Id)
                .Index(t => t.Reader_Id);

            CreateTable(
                "dbo.People",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                    Discriminator = c.String(nullable: false, maxLength: 128),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.HistoryItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    ReturnedDate = c.DateTime(nullable: false),
                    RealReturnedDate = c.DateTime(),
                    TakenDate = c.DateTime(nullable: false),
                    Status = c.String(),
                    Book_Id = c.Int(),
                    Reader_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.People", t => t.Reader_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Reader_Id);

            CreateTable(
                "dbo.AuthorBooks",
                c => new
                {
                    Author_Id = c.Int(nullable: false),
                    Book_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Author_Id, t.Book_Id })
                .ForeignKey("dbo.People", t => t.Author_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Author_Id)
                .Index(t => t.Book_Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.HistoryItems", "Reader_Id", "dbo.People");
            DropForeignKey("dbo.Books", "Reader_Id", "dbo.People");
            DropForeignKey("dbo.HistoryItems", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.People");
            DropIndex("dbo.AuthorBooks", new[] { "Book_Id" });
            DropIndex("dbo.AuthorBooks", new[] { "Author_Id" });
            DropIndex("dbo.HistoryItems", new[] { "Reader_Id" });
            DropIndex("dbo.HistoryItems", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "Reader_Id" });
            DropTable("dbo.AuthorBooks");
            DropTable("dbo.HistoryItems");
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}
