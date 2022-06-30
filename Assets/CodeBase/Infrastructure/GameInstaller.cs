using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.GameFlow;
using CodeBase.Infrastructure.GameFlow.States;
using CodeBase.Infrastructure.Services;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private CoroutineRunner _coroutineRunner;

        public override void InstallBindings()
        {
            BindSaveLoadService();
            BindGameVariables();
            BindAssetProvider();
            BindUiFactory();

            BindCoroutineRunner();
            BindSceneLoader();
            BindGameStateMachine();
        }
        
        private void BindSceneLoader()
        {
            Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle().NonLazy();
        }

        private void BindCoroutineRunner()
        {
            var coroutineRunner = Container.InstantiatePrefabForComponent<CoroutineRunner>(_coroutineRunner);
            Container.Bind<ICoroutineRunner>().FromInstance(coroutineRunner).AsSingle().NonLazy();
        }

        private void BindGameStateMachine()
        {
            
            Container.Bind<GameStateMachine>().To<GameStateMachine>().AsSingle().NonLazy();
            
            //gameStateMachine.Enter<MenuState>();
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
