using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.GameFlow;
using CodeBase.Infrastructure.GameFlow.States;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class GameInstaller : MonoInstaller, ICoroutineRunner
    {
        private GameStateMachine _gameStateMachine;

        public override void InstallBindings()
        {
            BindSaveLoadService();
            BindGameVariables();
            BindAssetProvider();
            BindUiFactory();

            BindCoroutineRunner();
            BindSceneLoader();
            
            BindGameStateMachine();
            BindGameRunner();
        }

        private void BindGameRunner()
        {
            Container.BindInterfacesAndSelfTo<GameRunner>().AsSingle().NonLazy();
        }

        private void BindSceneLoader()
        {
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle().NonLazy();
        }

        private void BindCoroutineRunner()
        {
            Container.Bind<ICoroutineRunner>().FromInstance(this).AsSingle().NonLazy();
        }

        private void BindGameStateMachine()
        {
            Container.Bind<BaseStateMachine>().To<GameStateMachine>().AsSingle().NonLazy();
        }

        private void BindUiFactory()
        {
            Container.Bind<IUiFactory>().To<UiFactory>().AsSingle().NonLazy();
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
            Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle().NonLazy();
        }
    }
}
