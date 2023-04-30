namespace KognitWallet.Models
{
    public class WalletModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal ValorAtual { get; set; }
        public string Banco { get; set; }
        public DateTime LastUpdate { get; set; }
        public virtual UserModel User { get; set; }
    }
}
