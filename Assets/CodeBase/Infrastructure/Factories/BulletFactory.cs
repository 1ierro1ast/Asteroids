using CodeBase.GamePlay.Weapons;
using CodeBase.Infrastructure.Services;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.Factories
{
    public class BulletFactory : IBulletFactory
    {
        private readonly WeaponSettings _weaponSettings;
        private readonly IAssetProvider _assetProvider;

        [Inject]
        public BulletFactory(WeaponSettings weaponSettings, IAssetProvider assetProvider)
        {
            _weaponSettings = weaponSettings;
            _assetProvider = assetProvider;
        }
        
        public Bullet CreateBullet(Vector3 position)
        {
            Bullet bullet = _assetProvider.Instantiate<Bullet>(_weaponSettings.BulletPrefab, position);
            bullet.SetSpeed(_weaponSettings.BulletSpeed);
            return bullet;
        }
    }
}