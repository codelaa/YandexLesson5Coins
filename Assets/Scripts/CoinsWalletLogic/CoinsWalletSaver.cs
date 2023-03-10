using UnityEngine;

namespace CoinsWalletLogic
{
    public class CoinsWalletSaver
    {
        private readonly CoinsWallet _coinsWallet;
    
        public CoinsWalletSaver(CoinsWallet coinsWallet)
        {
            _coinsWallet = coinsWallet;
            _coinsWallet.AmountChanged += Save;
        }
    
        private void Save(int amount) => PlayerPrefs.SetInt("Coins", amount);
    }
}