namespace WpfApp4.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InheritanceStrategyToTPC : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Authors");
            DropForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.People");
            DropForeignKey("dbo.Books", "Reader_Id", "dbo.People");
            DropForeignKey("dbo.HistoryItems", "Reader_Id", "dbo.People");
            DropPrimaryKey("dbo.Authors");
            CreateTable(
                "dbo.Readers",
                c => new
                {
                    Id = c.Int(nullable: false),
                    Name = c.String(),
                    Surname = c.String(),
                })
                .PrimaryKey(t => t.Id);

            AlterColumn("dbo.Authors", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Authors", "Id");
            AddForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.Authors", "Id", cascadeDelete: true);
            DropColumn("dbo.Authors", "BirthDay");
            DropColumn("dbo.Authors", "Discriminator");
        }

        public override void Down()
        {
            AddColumn("dbo.Authors", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Authors", "BirthDay", c => c.DateTime());
            DropForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.Authors");
            DropPrimaryKey("dbo.Authors");
            AlterColumn("dbo.Authors", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Readers");
            AddPrimaryKey("dbo.Authors", "Id");
            AddForeignKey("dbo.HistoryItems", "Reader_Id", "dbo.People", "Id");
            AddForeignKey("dbo.Books", "Reader_Id", "dbo.People", "Id");
            AddForeignKey("dbo.AuthorBooks", "Author_Id", "dbo.People", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Authors", newName: "People");
        }
    }
}
