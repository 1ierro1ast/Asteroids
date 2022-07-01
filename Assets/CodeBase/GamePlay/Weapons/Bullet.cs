using UnityEngine;

namespace CodeBase.GamePlay.Weapons
{
    [RequireComponent(typeof(CharacterController))]
    public class Bullet : MonoBehaviour
    {
        private CharacterController _characterController;
        private float _speed;
        
        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _characterController.Move(Vector3.right * _speed);
        }

        public void SetSpeed(float speed)
        {
            _speed = speed;
        }
    }
}