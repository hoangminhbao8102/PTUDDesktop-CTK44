using Restaurant.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL
{
    public class RestaurantDbContext : DbContext
    {
        // Tham chiếu tới các nhóm món ăn trong bảng Category
        public DbSet<Category>? Categories { get; set; }

        // Tham chiếu tới các món ăn, đồ uống trong bảng Food
        public DbSet<Food>? Foods { get; set; }

        // Tham chiếu tới các bàn trong nhà hàng
        public DbSet<Table>? Tables { get; set; }

        // Tham chiếu tới các chi tiết hóa đơn
        public DbSet<BillDetail>? BillDetails { get; set; }

        // Tham chiếu tới các hóa đơn
        public DbSet<Bill>? Bills { get; set; }

        // Tham chiếu tới vai trò
        public DbSet<Role>? Roles { get; set; }

        // Tham chiếu tới tài khoản và vai trò tài khoản
        public DbSet<RoleAccount>? RoleAccounts { get; set; }

        // Tham chiếu tới các tài khoản
        public DbSet<Account>? Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Xóa bỏ quy tắc sử dụng danh từ số nhiều cho tên bảng
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Account>()
                .HasKey(a => a.AccountName); // Xác định AccountName là khóa chính

            modelBuilder.Entity<RoleAccount>()
                .HasKey(ra => new { ra.RoleId, ra.AccountName }); // Khóa chính phức hợp (nếu cần)

            // Định nghĩa mối quan hệ một-nhiều giữa Category và Food
            modelBuilder.Entity<Food>()
                .HasRequired(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.FoodCategoryId)
                .WillCascadeOnDelete(true);

            // Định nghĩa mối quan hệ một-nhiều giữa Table và Bill
            modelBuilder.Entity<Bill>()
                .HasRequired(x => x.Table!)
                .WithMany(t => t.Bills)
                .HasForeignKey(x => x.TableId)
                .WillCascadeOnDelete(false);

            // Định nghĩa mối quan hệ một-nhiều giữa Bill và BillDetail
            modelBuilder.Entity<BillDetail>()
                .HasRequired(bd => bd.Bill!)
                .WithMany(b => b.BillDetails)
                .HasForeignKey(bd => bd.InvoiceId)
                .WillCascadeOnDelete(true);

            // Định nghĩa mối quan hệ một-nhiều giữa Food và BillDetail
            modelBuilder.Entity<BillDetail>()
                .HasRequired(bd => bd.Food)
                .WithMany()
                .HasForeignKey(bd => bd.FoodId)
                .WillCascadeOnDelete(false);

            // Định nghĩa mối quan hệ nhiều-nhiều giữa Role và Account thông qua RoleAccount
            modelBuilder.Entity<RoleAccount>()
                .HasRequired(ra => ra.Role!)
                .WithMany(r => r.RoleAccounts)
                .HasForeignKey(ra => ra.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoleAccount>()
                .HasRequired(ra => ra.Account!)
                .WithMany(a => a.RoleAccounts)
                .HasForeignKey(ra => ra.AccountName)
                .WillCascadeOnDelete(false);
        }
    }
}
