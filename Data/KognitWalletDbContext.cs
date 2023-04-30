using KognitWallet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KognitWallet.Data
{
    public class KognitWalletDbContext : DbContext
    {
        public KognitWalletDbContext(DbContextOptions<KognitWalletDbContext>options):base(options)
        {
            
        }
        public KognitWalletDbContext():base()
        {
            
        }
        public DbSet<UserModel>Users { get; set; }
        public DbSet<WalletModel>Wallets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>();
            modelBuilder.Entity<WalletModel>().Property(x => x.ValorAtual).HasColumnType("decimal(5,3)");
            modelBuilder.Entity<WalletModel>();
            base.OnModelCreating(modelBuilder);
        }
       
    }
}

