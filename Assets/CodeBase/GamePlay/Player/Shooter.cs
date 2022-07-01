using CodeBase.GamePlay.Input;
using CodeBase.Infrastructure.Factories;
using UnityEngine;
using Zenject;

namespace CodeBase.GamePlay.Player
{
    public class Shooter : MonoBehaviour
    {
        private IInputHandler _inputHandler;
        private IBulletFactory _bulletFactory;

        [Inject]
        public void Construct(IInputHandler inputHandler, IBulletFactory bulletFactory)
        {
            _inputHandler = inputHandler;
            _bulletFactory = bulletFactory;
            _inputHandler.ShootButtonPressed += InputHandlerOnShootButtonPressed;
        }

        private void InputHandlerOnShootButtonPressed()
        {
            _bulletFactory.CreateBullet(transform.position);
        }

        private void OnDestroy()
        {
            _inputHandler.ShootButtonPressed -= InputHandlerOnShootButtonPressed;
        }
    }
}