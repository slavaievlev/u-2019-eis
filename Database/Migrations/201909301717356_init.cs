namespace EisDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChartOfAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        SubcontoOne = c.Int(),
                        SubcontoTwo = c.Int(),
                        SubcontoThree = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DirectoryGMProductSeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DirectoryGMId = c.Int(nullable: false),
                        ProductSeriesId = c.Int(nullable: false),
                        RetailPrice = c.Int(nullable: false),
                        PurchasePrice = c.Int(nullable: false),
                        DeadlineForImplementation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DirectoryGMs", t => t.DirectoryGMId, cascadeDelete: true)
                .ForeignKey("dbo.ProductSeries", t => t.ProductSeriesId, cascadeDelete: true)
                .Index(t => t.DirectoryGMId)
                .Index(t => t.ProductSeriesId);
            
            CreateTable(
                "dbo.DirectoryGMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JournalOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Sum = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        ProviderId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        DirectoryGMProductSeriesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.DirectoryGMProductSeries", t => t.DirectoryGMProductSeriesId, cascadeDelete: true)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId)
                .Index(t => t.EmployeeId)
                .Index(t => t.DirectoryGMProductSeriesId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(nullable: false),
                        SubdivisionId = c.Int(nullable: false),
                        EmployeePositionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeesPositions", t => t.EmployeePositionId, cascadeDelete: true)
                .ForeignKey("dbo.Subdivisions", t => t.SubdivisionId, cascadeDelete: true)
                .Index(t => t.SubdivisionId)
                .Index(t => t.EmployeePositionId);
            
            CreateTable(
                "dbo.EmployeesPositions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subdivisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JournalEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubcontoDebitOne = c.String(),
                        SubcontoDebitTwo = c.String(),
                        SubcontoDebitThree = c.String(),
                        SubcontoCreditOne = c.String(),
                        SubcontoCreditTwo = c.String(),
                        SubcontoCreditThree = c.String(),
                        Sum = c.Int(nullable: false),
                        Operation = c.String(nullable: false),
                        Comment = c.String(),
                        Count = c.Int(nullable: false),
                        JournalOperationId = c.Int(nullable: false),
                        DebitAccountId = c.Int(),
                        CreditAccountId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ChartOfAccounts", t => t.CreditAccountId)
                .ForeignKey("dbo.ChartOfAccounts", t => t.DebitAccountId)
                .ForeignKey("dbo.JournalOperations", t => t.JournalOperationId, cascadeDelete: true)
                .Index(t => t.JournalOperationId)
                .Index(t => t.DebitAccountId)
                .Index(t => t.CreditAccountId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductSeries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DirectoryGMProductSeries", "ProductSeriesId", "dbo.ProductSeries");
            DropForeignKey("dbo.JournalOperations", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.JournalEntries", "JournalOperationId", "dbo.JournalOperations");
            DropForeignKey("dbo.JournalEntries", "DebitAccountId", "dbo.ChartOfAccounts");
            DropForeignKey("dbo.JournalEntries", "CreditAccountId", "dbo.ChartOfAccounts");
            DropForeignKey("dbo.JournalOperations", "DirectoryGMProductSeriesId", "dbo.DirectoryGMProductSeries");
            DropForeignKey("dbo.Employees", "SubdivisionId", "dbo.Subdivisions");
            DropForeignKey("dbo.JournalOperations", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "EmployeePositionId", "dbo.EmployeesPositions");
            DropForeignKey("dbo.DirectoryGMProductSeries", "DirectoryGMId", "dbo.DirectoryGMs");
            DropIndex("dbo.JournalEntries", new[] { "CreditAccountId" });
            DropIndex("dbo.JournalEntries", new[] { "DebitAccountId" });
            DropIndex("dbo.JournalEntries", new[] { "JournalOperationId" });
            DropIndex("dbo.Employees", new[] { "EmployeePositionId" });
            DropIndex("dbo.Employees", new[] { "SubdivisionId" });
            DropIndex("dbo.JournalOperations", new[] { "DirectoryGMProductSeriesId" });
            DropIndex("dbo.JournalOperations", new[] { "EmployeeId" });
            DropIndex("dbo.JournalOperations", new[] { "ProviderId" });
            DropIndex("dbo.DirectoryGMProductSeries", new[] { "ProductSeriesId" });
            DropIndex("dbo.DirectoryGMProductSeries", new[] { "DirectoryGMId" });
            DropTable("dbo.ProductSeries");
            DropTable("dbo.Providers");
            DropTable("dbo.JournalEntries");
            DropTable("dbo.Subdivisions");
            DropTable("dbo.EmployeesPositions");
            DropTable("dbo.Employees");
            DropTable("dbo.JournalOperations");
            DropTable("dbo.DirectoryGMs");
            DropTable("dbo.DirectoryGMProductSeries");
            DropTable("dbo.ChartOfAccounts");
        }
    }
}
