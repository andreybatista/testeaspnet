using KognitWallet.Models;

namespace KognitWallet.Repository.Interfaces
{
    public interface IWalletRepository
    {
        WalletModel AddWallet(WalletModel wallet);
        List<WalletModel> GetWalletsByUserId(int userId);

        List<WalletModel> GetWallets(int userId);
    }
}
