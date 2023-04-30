using KognitWallet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KognitWallet.Data.Map
{
    public class WalletMap : IEntityTypeConfiguration<WalletModel>
    {
        public void Configure(EntityTypeBuilder<WalletModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ValorAtual).IsRequired().HasPrecision(5,3);
            builder.Property(x => x.Banco).IsRequired();
            builder.Property(x => x.LastUpdate);
            builder.Property(x => x.User).IsRequired();
        }
    }
}
