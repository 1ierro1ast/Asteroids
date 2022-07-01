using CodeBase.GamePlay.Input;
using UnityEngine;
using Zenject;

namespace CodeBase.GamePlay.Player
{
    [RequireComponent(typeof(CharacterController))]
    public class SpaceshipMover : MonoBehaviour
    {
        private CharacterController _characterController;
        private IInputHandler _inputHandler;
        private SpaceshipSettings _spaceshipSettings;

        [Inject]
        public void Construct(IInputHandler inputHandler, SpaceshipSettings spaceshipSettings)
        {
            _inputHandler = inputHandler;
            _spaceshipSettings = spaceshipSettings;
        }

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _characterController.Move(new Vector3(
                _inputHandler.HorizontalMove,
                _inputHandler.VerticalMove, 0) * _spaceshipSettings.Speed);
        }
    }
}