using CodeBase.GamePlay.Asteroids;
using CodeBase.GamePlay.Player;
using CodeBase.GamePlay.Weapons;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Installers
{
    public sealed class GameSettingsInstaller : MonoInstaller
    {
        [SerializeField] private AsteroidsSettings _asteroidsSettings;
        [SerializeField] private SpaceshipSettings _spaceshipSettings;
        [SerializeField] private WeaponSettings _weaponSettings;

        public override void InstallBindings()
        {
            BindWeaponSettings();
            BindSpaceshipSettings();
            BindAsteroidsSettings();
        }

        private void BindWeaponSettings()
        {
            Container.Bind<WeaponSettings>().FromScriptableObject(_weaponSettings).AsSingle();
        }

        private void BindSpaceshipSettings()
        {
            Container.Bind<SpaceshipSettings>().FromScriptableObject(_spaceshipSettings).AsSingle();
        }

        private void BindAsteroidsSettings()
        {
            Container.Bind<AsteroidsSettings>().FromScriptableObject(_asteroidsSettings).AsSingle();
        }
    }
}