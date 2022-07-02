using CodeBase.GamePlay.Asteroids;
using CodeBase.GamePlay.Input;
using CodeBase.GamePlay.Player;
using CodeBase.Infrastructure.Factories;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers
{
    public sealed class GameplayInstaller : MonoInstaller
    {
        [SerializeField] private Spaceship _spaceship;
        [SerializeField] private AsteroidsSpawn _asteroidsSpawn;
        public override void InstallBindings()
        {
            BindSpaceship();
            BindAsteroidsSpawn();
            BindInputHandler();
            BindAsteroidsFactory();
            BindBulletFactory();
        }

        private void BindBulletFactory()
        {
            Container
                .Bind<IBulletFactory>()
                .To<BulletFactory>()
                .AsSingle()
                .NonLazy();
        }

        private void BindAsteroidsSpawn()
        {
            Container
                .Bind<AsteroidsSpawn>()
                .FromComponentInNewPrefab(_asteroidsSpawn)
                .AsSingle()
                .NonLazy();
        }

        private void BindSpaceship()
        {
            Container
                .Bind<Spaceship>()
                .FromComponentInNewPrefab(_spaceship)
                .AsSingle()
                .NonLazy();
        }

        private void BindInputHandler()
        {
            Container
                .BindInterfacesAndSelfTo<InputHandler>()
                .AsSingle()
                .NonLazy();
        }

        private void BindAsteroidsFactory()
        {
            Container
                .Bind<IAsteroidsFactory>()
                .To<AsteroidsFactory>()
                .AsSingle()
                .NonLazy();
        }
    }
}