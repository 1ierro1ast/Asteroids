using CodeBase.Infrastructure.StateMachine;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class LoadGameState : IState
    {
        private readonly GameStateMachine _gameStateMachine;

        public LoadGameState(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
        }
    }
}