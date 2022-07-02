using System;
using UnityEngine;
using Zenject;

namespace CodeBase.GamePlay.Player
{
    [RequireComponent(typeof(SpaceshipMover))]
    public class Spaceship : MonoBehaviour
    {
        private float _health;
        public event Action SpaceshipDestroyed;
        public event Action<float> ChangeHealth;

        [Inject]
        private void Construct(SpaceshipSettings spaceshipSettings)
        {
            _health = spaceshipSettings.Health;
        }
        
        public void SetDamage(float damage)
        {
            _health -= damage;
            if (_health <= 0)
            {
                _health = 0;
                SpaceshipDestroyed?.Invoke();
            }

            ChangeHealth?.Invoke(_health);
        }
    }
}