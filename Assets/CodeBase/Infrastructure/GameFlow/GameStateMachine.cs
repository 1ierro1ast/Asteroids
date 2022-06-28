using System;
using System.Collections.Generic;
using CodeBase.Infrastructure.GameFlow.States;
using CodeBase.Infrastructure.StateMachine;

namespace CodeBase.Infrastructure.GameFlow
{
    public class GameStateMachine : BaseStateMachine
    {
        public GameStateMachine()
        {
            States = new Dictionary<Type, IExitableState>()
            {
                [typeof(MenuState)] = new MenuState(this),
                [typeof(LoadGameState)] = new LoadGameState(this),
                [typeof(GameplayState)] = new GameplayState(this),
                [typeof(ResultState)] = new ResultState(this)
            };
        }
    }
}