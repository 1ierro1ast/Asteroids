using CodeBase.GamePlay.Weapons;
using UnityEngine;

namespace CodeBase.Infrastructure.Factories
{
    public interface IBulletFactory
    {
        public Bullet CreateBullet(Vector3 position);
    }
}