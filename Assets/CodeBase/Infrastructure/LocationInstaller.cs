using CodeBase.Infrastructure.Services;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class LocationInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindSaveLoadService();
            BindGameVariables();
            BindAssetProvider();
        }

        private void BindGameVariables()
        {
            Container.Bind<IGameVariables>().To<GameVariables>().AsSingle().NonLazy();
        }
        
        private void BindAssetProvider()
        {
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle().NonLazy();
        }

        private void BindSaveLoadService()
        {
            Container.Bind<ISaveLoadService>().AsSingle().NonLazy();
        }
    }
}
