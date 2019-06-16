namespace Connection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersianMG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AntTbl",
                c => new
                    {
                        AntID = c.Int(nullable: false, identity: true),
                        ArticleGroup = c.Boolean(nullable: false),
                        NewsGroup = c.Boolean(nullable: false),
                        TranslateGroup = c.Boolean(nullable: false),
                        WordName = c.String(nullable: false, maxLength: 500),
                        SavePath = c.String(nullable: false, maxLength: 1000),
                        WordValue = c.Decimal(nullable: false, precision: 18, scale: 0),
                        AuthorID = c.Int(nullable: false),
                        ActDate = c.String(nullable: false, maxLength: 10),
                        WordCount = c.Long(nullable: false),
                        Title = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.AntID);
            
            CreateTable(
                "dbo.AuthorTbl",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(nullable: false, maxLength: 500),
                        ArticleGroup = c.Boolean(nullable: false),
                        NewsGroup = c.Boolean(nullable: false),
                        TranslateGroup = c.Boolean(nullable: false),
                        TellNumber = c.String(nullable: false, maxLength: 500, unicode: false),
                        AccountNumber = c.String(nullable: false, maxLength: 500),
                        CardNumber = c.String(nullable: false, maxLength: 500),
                        BankName = c.String(nullable: false, maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 500),
                        ArticleValue = c.Decimal(nullable: false, precision: 18, scale: 0),
                        NewsValue = c.Decimal(nullable: false, precision: 18, scale: 0),
                        TranslateValue = c.Decimal(nullable: false, precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.CaseTbl",
                c => new
                    {
                        CaseID = c.Int(nullable: false, identity: true),
                        AuthorID = c.Int(nullable: false),
                        Explain = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.CaseID)
                .ForeignKey("dbo.AuthorTbl", t => t.AuthorID)
                .Index(t => t.AuthorID);
            
        }
        public override void Down()
        {
            DropForeignKey("dbo.CaseTbl", "AuthorID", "dbo.AuthorTbl");
            DropIndex("dbo.CaseTbl", new[] { "AuthorID" });
            DropTable("dbo.CaseTbl");
            DropTable("dbo.AuthorTbl");
            DropTable("dbo.AntTbl");
        }
    }
}
