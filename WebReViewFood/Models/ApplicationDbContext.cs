using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using WebReviewFood.Models;

namespace WebReViewFood.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ReviewFood> ReviewFoods { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}