using CodeBase.GamePlay.Player;
using CodeBase.GamePlay.Weapons;
using CodeBase.Infrastructure.Services;
using UnityEngine;

namespace CodeBase.GamePlay.Asteroids
{
    [RequireComponent(typeof(Rigidbody))]
    public class Asteroid : MonoBehaviour
    {
        private IGameVariables _gameVariables;
        private Rigidbody _rigidbody;
        private float _speed;
        private float _damage;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void SetParameters(float speed, float size, float damage, IGameVariables gameVariables)
        {
            _gameVariables = gameVariables;
            _speed = speed;
            _damage = damage;
            transform.localScale = new Vector3(size, size, size);
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(Vector3.left * _speed, ForceMode.VelocityChange);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Bullet bullet))
            {
                _gameVariables.AddScores();
                Destroy(bullet);
                Destroy(gameObject);
            }

            if (other.TryGetComponent(out Spaceship spaceship))
            {
                spaceship.SetDamage(_damage);
                Destroy(gameObject);
            }
        }
    }
}