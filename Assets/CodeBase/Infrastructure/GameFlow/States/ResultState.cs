using CodeBase.Infrastructure.StateMachine;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class ResultState : IState
    {
        private readonly GameStateMachine _gameStateMachine;

        public ResultState(GameStateMachine gameStateMachine)
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