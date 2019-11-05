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
                .ForeignKey("dbo.Readers", t => t.Reader_Id)
                .Index(t => t.Reader_Id);

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
                .ForeignKey("dbo.Readers", t => t.Reader_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Reader_Id);

            CreateTable(
                "dbo.ReaderCards",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Readers", t => t.Id)
                .Index(t => t.Id);

            CreateTable(
                "dbo.AuthorBooks",
                c => new
                {
                    Author_Id = c.Int(nullable: false),
                    Book_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Author_Id, t.Book_Id })
                .ForeignKey("dbo.Authors", t => t.Author_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Author_Id)
                .Index(t => t.Book_Id);

            CreateTable(
                "dbo.Authors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Readers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Surname = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropForeignKey("dbo.HistoryItems", "Reader_Id", "dbo.Readers");
            DropForeignKey("dbo.ReaderCards", "Id", "dbo.Readers");
            DropForeignKey("dbo.Books", "Reader_Id", "dbo.Readers");
            DropForeignKey("dbo.HistoryItems", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Charters", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.Authors");
            DropIndex("dbo.AuthorBooks", new[] { "Book_Id" });
            DropIndex("dbo.AuthorBooks", new[] { "Author_Id" });
            DropIndex("dbo.ReaderCards", new[] { "Id" });
            DropIndex("dbo.HistoryItems", new[] { "Reader_Id" });
            DropIndex("dbo.HistoryItems", new[] { "Book_Id" });
            DropIndex("dbo.Charters", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "Reader_Id" });
            DropTable("dbo.Readers");
            DropTable("dbo.Authors");
            DropTable("dbo.AuthorBooks");
            DropTable("dbo.ReaderCards");
            DropTable("dbo.HistoryItems");
            DropTable("dbo.Charters");
            DropTable("dbo.Books");
        }
    }
}
