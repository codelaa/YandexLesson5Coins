using TMPro;
using UnityEngine;

namespace CoinsWalletLogic
{
    public class CoinsWalletView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textMeshPro;
        [SerializeField] private Animator _animator;
        
        public void ChangeAmount(int amount)
        {
            _textMeshPro.text = $"Coins: {amount}";
            _animator.SetTrigger("OnPickupCoin");
        }
    }
}