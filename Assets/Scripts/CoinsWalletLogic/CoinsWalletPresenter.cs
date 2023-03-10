using UnityEngine;
using UnityEngine.EventSystems;

namespace CoinsWalletLogic
{
    public class CoinsWalletPresenter : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private CoinsWalletView _coinsView;
        private CoinsWallet _coinsWallet;

        public void Construct(CoinsWallet coinsWallet)
        {
            _coinsWallet = coinsWallet;
            enabled = true;
        }

        private void OnEnable() => _coinsWallet.AmountChanged += _coinsView.ChangeAmount;

        private void Start() => _coinsView.ChangeAmount(_coinsWallet.Amount);

        private void OnDisable() => _coinsWallet.AmountChanged -= _coinsView.ChangeAmount;

        public void OnPointerClick(PointerEventData eventData) => _coinsWallet.OnPointerClick();
    }
}