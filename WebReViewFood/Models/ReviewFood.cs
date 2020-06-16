using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebReviewFood.Models
{
    public class ReviewFood
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [DisplayName("Tên Bài Viết")]
        public string TenBaiReview { get; set; }
        [Required]
        [DisplayName("Thông Tin")]
        public string ThongtinFood { get; set; }
        [Required]
        [DisplayName("Đánh Giá")]
        public string DanhGiaFood { get; set; }
        [DisplayName("Hình Ảnh")]
        public string ImageCover { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFiles { get; set; }
    }
}