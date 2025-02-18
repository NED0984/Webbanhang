﻿namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "IsActice", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "Alias", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Title", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "SeoKeywords", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Title", c => c.String());
            DropColumn("dbo.tb_ProductCategory", "Alias");
            DropColumn("dbo.tb_Product", "IsActice");
        }
    }
}
