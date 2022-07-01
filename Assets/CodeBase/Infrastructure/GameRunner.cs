using CodeBase.Infrastructure.GameFlow;
using CodeBase.Infrastructure.GameFlow.States;
using CodeBase.Infrastructure.StateMachine;
using Zenject;

namespace CodeBase.Infrastructure
{
    public sealed class GameRunner : IInitializable
    {
        private readonly GameStateMachine _gameStateMachine;

        [Inject] 
        public GameRunner(BaseStateMachine baseStateMachine)
        {
            _gameStateMachine = baseStateMachine as GameStateMachine;
        }
        public void Initialize()
        {
            _gameStateMachine.Enter<MenuState>();
        }
    }
}