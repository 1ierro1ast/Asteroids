using UnityEngine;

namespace CodeBase.GamePlay.Asteroids
{
    [RequireComponent(typeof(CharacterController))]
    public class Asteroid : MonoBehaviour
    {
        private CharacterController _characterController;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }
    }
}