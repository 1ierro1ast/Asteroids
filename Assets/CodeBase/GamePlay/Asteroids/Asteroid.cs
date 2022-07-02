using System;
using CodeBase.GamePlay.Player;
using CodeBase.GamePlay.Weapons;
using UnityEngine;

namespace CodeBase.GamePlay.Asteroids
{
    [RequireComponent(typeof(CharacterController))]
    public class Asteroid : MonoBehaviour
    {
        private CharacterController _characterController;
        private float _speed;
        private float _damage;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public void SetParameters(float speed, float size, float damage)
        {
            _speed = speed;
            _damage = damage;
            transform.localScale = new Vector3(size, size, size);
        }

        private void Update()
        {
            _characterController.Move(Vector3.left * _speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Bullet bullet))
            {
                Destroy(gameObject);
            }

            if (other.TryGetComponent(out Spaceship spaceship))
            {
                spaceship.SetDamage(_damage);
            }
        }
    }
}