using CoinsWalletLogic;
using UnityEngine;
using Zenject;

public class Save : MonoBehaviour
{
    private CoinsWallet _coinsWallet;
    private CoinsWalletSaver _coinWalletSaver;

    [Inject]
    private void Construct(CoinsWallet coinsWallet)
    {
        _coinsWallet = coinsWallet;
    }
        
    private void Awake()
    {
        _coinWalletSaver = new CoinsWalletSaver(_coinsWallet);
    }
}