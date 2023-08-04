using DA_BanDoChoi_N123_Share.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DA_BanDoChoi_API.Data
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext()
        {
        }
        public ShopDBContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Age> Ages { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartDetail> CartDetails { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FavoritesListDetail> FavoritesListDetails { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MemberType> MemberTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentHistory> PaymentHistories { get; set; }
        public virtual DbSet<PointHistory> PointHistories { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductCategoryParent> ProductCategoryParents { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Sound> Sounds { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<VoucherDetail> VoucherDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AKSDRER\\MOMO;Initial Catalog=DuAnXuong;Integrated Security=True");
        }
    }
}
