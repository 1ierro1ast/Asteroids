using UnityEngine;

namespace CodeBase.GamePlay.Weapons
{
    [CreateAssetMenu(menuName = "Settings/Create weapon settings", fileName = "WeaponSettings", order = 51)]
    public class WeaponSettings : ScriptableObject
    {
        [SerializeField] private float _bulletSpeed;
        [SerializeField] private Bullet _bulletPrefab;

        public float BulletSpeed => _bulletSpeed;
        public Bullet BulletPrefab => _bulletPrefab;
    }
}