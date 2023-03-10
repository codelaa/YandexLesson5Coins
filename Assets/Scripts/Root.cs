using CoinsWalletLogic;
using UnityEngine;

public class Root : MonoBehaviour
{
    [SerializeField] private CoinsWalletPresenter _coinsWalletPresenter;
    private CoinsWallet _coinsWallet;
    private CoinsWalletSaver _coinWalletSaver;
        
    private void Awake()
    {
        _coinsWallet = new CoinsWallet(PlayerPrefs.GetInt("Coins", 0));
        _coinsWalletPresenter.Construct(_coinsWallet);
        _coinWalletSaver = new CoinsWalletSaver(_coinsWallet);
    }
}