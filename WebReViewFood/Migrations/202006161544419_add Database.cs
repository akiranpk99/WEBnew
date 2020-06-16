namespace WebReViewFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ReviewFoods(TenBaiReview,ThongtinFood,DanhGiaFood,ImageCover) VALUES(N'Sống Ảo Trăm Like Với Tiệm Cà Phê Vintage Siêu Xinh Không Thể Bỏ Lỡ Khi Đến Quy Nhơn !',N'Muôn góc góc nào cũng xinh, với thiết kế kiểu thời Ông bà anh pha lẫn một chút hiện đại. Đây là nơi lý tưởng cho các tín đồ sống ảo.',N'Menu đa dạng các món giá chỉ từ 30k.',N'~/Image/13205007124.jpg')");
            Sql("INSERT INTO ReviewFoods(TenBaiReview,ThongtinFood,DanhGiaFood,ImageCover) VALUES(N'Sống Ảo Trăm Like Với Tiệm Cà Phê AkiraOmega Siêu Xinh Không Thể Bỏ Lỡ Khi Đến Quy Nhơn !',N'Muôn góc góc nào cũng xinh, với thiết kế kiểu thời Ông bà anh pha lẫn một chút hiện đại. Đây là nơi lý tưởng cho các tín đồ sống ảo.',N'Menu đa dạng các món giá chỉ từ 30k.',N'~/Image/39205620373.png')");
            Sql("INSERT INTO ReviewFoods(TenBaiReview,ThongtinFood,DanhGiaFood,ImageCover) VALUES(N'Sống Ảo Trăm Like Với Tiệm Cà Phê VinaHouse Siêu Xinh Không Thể Bỏ Lỡ Khi Đến Quy Nhơn !',N'Muôn góc góc nào cũng xinh, với thiết kế kiểu thời Ông bà anh pha lẫn một chút hiện đại. Đây là nơi lý tưởng cho các tín đồ sống ảo.',N'Menu đa dạng các món giá chỉ từ 30k.',N'~/Image/24202824143.jpg')");
        }
        
        public override void Down()
        {
        }
    }
}
