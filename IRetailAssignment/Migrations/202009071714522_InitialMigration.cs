namespace IRetailAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.customer",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        email = c.String(),
                        password = c.String(),
                        phone = c.String(),
                        address = c.String(),
                        loggedIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "public.order",
                c => new
                    {
                        orderId = c.Int(nullable: false, identity: true),
                        customerId = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                        quantity = c.Int(nullable: false),
                        orderNo = c.Int(nullable: false),
                        description = c.String(),
                        status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.orderId)
                .ForeignKey("public.customer", t => t.customerId, cascadeDelete: true)
                .ForeignKey("public.product", t => t.productId, cascadeDelete: true)
                .Index(t => t.customerId)
                .Index(t => t.productId);
            
            CreateTable(
                "public.product",
                c => new
                    {
                        productId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Int(nullable: false),
                        description = c.String(),
                        quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.order", "productId", "public.product");
            DropForeignKey("public.order", "customerId", "public.customer");
            DropIndex("public.order", new[] { "productId" });
            DropIndex("public.order", new[] { "customerId" });
            DropTable("public.product");
            DropTable("public.order");
            DropTable("public.customer");
        }
    }
}
