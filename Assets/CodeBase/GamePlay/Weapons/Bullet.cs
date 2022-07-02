using UnityEngine;

namespace CodeBase.GamePlay.Weapons
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        private float _speed;
        
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(Vector3.right * _speed, ForceMode.VelocityChange);
        }

        public void SetSpeed(float speed)
        {
            _speed = speed;
        }
    }
}