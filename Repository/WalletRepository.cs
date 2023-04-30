using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using KognitWallet.Models;
using KognitWallet.Data;
using KognitWallet.Repository.Interfaces;

namespace KognitWallet.Repository
{
    public class WalletRepository: IWalletRepository
    {
        private readonly KognitWalletDbContext _context;

        public WalletRepository(KognitWalletDbContext context)
        {
            _context = context;
        }

        public List<WalletModel> GetWallets(int userId)
        {
            return _context.Wallets.Where(w => w.UserId == userId).ToList();
        }

        public WalletModel AddWallet(WalletModel wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet;
        }

        public List<WalletModel> GetWalletsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

    }

}
