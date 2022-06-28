using CodeBase.Infrastructure.StateMachine;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class MenuState : IState
    {
        private readonly GameStateMachine _gameStateMachine;

        public MenuState(GameStateMachine gameStateMachine)
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