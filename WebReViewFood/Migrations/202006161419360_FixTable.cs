namespace WebReViewFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReviewFoods", "ImageCover", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReviewFoods", "ImageCover", c => c.String(nullable: false));
        }
    }
}
