namespace WpfApp4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorBirthDay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "BirthDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "BirthDay");
        }
    }
}
