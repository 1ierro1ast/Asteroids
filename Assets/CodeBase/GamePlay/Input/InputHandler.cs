using System;
using UnityEngine;
using Zenject;

namespace CodeBase.GamePlay.Input
{
    public sealed class InputHandler : IInputHandler, ITickable
    {
        public event Action ShootButtonPressed;
        public float HorizontalMove => UnityEngine.Input.GetAxis("Horizontal");
        public float VerticalMove => UnityEngine.Input.GetAxis("Vertical");
        
        public void Tick()
        {
            HandleShoot();
        }

        private void HandleShoot()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Space))
                ShootButtonPressed?.Invoke();
        }
    }
}