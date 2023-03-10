using System;

namespace CoinsWalletLogic
{
    public class CoinsWallet 
    {
        public int Amount { get; private set; }

        public event Action<int> AmountChanged;

        public CoinsWallet(int amount)
        {
            Amount = amount;
        }

        public void OnPointerClick()
        {
            OnPickupCoin();
        }

        public void OnPickupCoin()
        {
            Amount++;
            AmountChanged?.Invoke(Amount);
        }

        public bool TryDiscard(int price)
        {
            if (EnoughCoins(price))
                return false;

            Amount -= price;
        
            AmountChanged?.Invoke(Amount);

            return true;
        }

        private bool EnoughCoins(int price) => Amount < price;
    }
}