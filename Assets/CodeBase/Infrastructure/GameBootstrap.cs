using CodeBase.Infrastructure.GameFlow;
using CodeBase.Infrastructure.GameFlow.States;
using UnityEngine;

namespace CodeBase.Infrastructure
{
    public class GameBootstrap : MonoBehaviour
    {
        private GameStateMachine _gameStateMachine;
        
        private void Awake()
        {
            _gameStateMachine = new GameStateMachine();
            _gameStateMachine.Enter<MenuState>();
        }
    }
}