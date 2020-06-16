namespace WebReViewFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableReview : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReviewFoods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenBaiReview = c.String(nullable: false, maxLength: 255),
                        ThongtinFood = c.String(nullable: false),
                        DanhGiaFood = c.String(nullable: false),
                        ImageCover = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReviewFoods");
        }
    }
}
