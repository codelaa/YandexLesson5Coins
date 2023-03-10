using CoinsWalletLogic;
using UnityEngine;
using Zenject;

namespace Installers
{
    public class CoinsWalletInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            var instance = new CoinsWallet(PlayerPrefs.GetInt("Coins", 0));
                
            Container
                .Bind<CoinsWallet>()
                .FromInstance(instance)
                .AsSingle();

        }
    }
}