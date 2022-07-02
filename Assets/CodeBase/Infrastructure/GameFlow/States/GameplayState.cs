using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui;
using UnityEngine;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class GameplayState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly LoadingCurtain _loadingCurtain;

        public GameplayState(GameStateMachine gameStateMachine, LoadingCurtain loadingCurtain)
        {
            _gameStateMachine = gameStateMachine;
            _loadingCurtain = loadingCurtain;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            Debug.Log("Gameplay here");
            _loadingCurtain.Close();
        }
    }
}