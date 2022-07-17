namespace QurilishKompaniyasi1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbQurilish : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deficits",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyName = c.String(),
                        Quantity = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Orderid = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Customerid = c.Int(nullable: false),
                        Employeid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Orderid)
                .ForeignKey("dbo.Customers", t => t.Customerid, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employeid, cascadeDelete: true)
                .Index(t => t.Customerid)
                .Index(t => t.Employeid);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Customerid = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Address = c.String(),
                        PhoneNummer = c.String(),
                    })
                .PrimaryKey(t => t.Customerid);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Employeid = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Position = c.String(),
                        Address = c.String(),
                        PhoneNummer = c.String(),
                        StartWorking = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Employeid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CompanyName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Categoryid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.Categoryid, cascadeDelete: true)
                .Index(t => t.Categoryid);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Categoryid = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Categoryid);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        Product_id = c.Int(nullable: false),
                        Order_Orderid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_id, t.Order_Orderid })
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_Orderid, cascadeDelete: true)
                .Index(t => t.Product_id)
                .Index(t => t.Order_Orderid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductOrders", "Order_Orderid", "dbo.Orders");
            DropForeignKey("dbo.ProductOrders", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Products", "Categoryid", "dbo.Categories");
            DropForeignKey("dbo.Orders", "Employeid", "dbo.Employees");
            DropForeignKey("dbo.Orders", "Customerid", "dbo.Customers");
            DropIndex("dbo.ProductOrders", new[] { "Order_Orderid" });
            DropIndex("dbo.ProductOrders", new[] { "Product_id" });
            DropIndex("dbo.Products", new[] { "Categoryid" });
            DropIndex("dbo.Orders", new[] { "Employeid" });
            DropIndex("dbo.Orders", new[] { "Customerid" });
            DropTable("dbo.ProductOrders");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Deficits");
        }
    }
}
