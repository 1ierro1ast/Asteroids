using System;
using System.Collections.Generic;
using CodeBase.Infrastructure.GameFlow.States;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using Zenject;

namespace CodeBase.Infrastructure.GameFlow
{
    public class GameStateMachine : BaseStateMachine, IGameStateMachine
    {
        [Inject]
        public GameStateMachine(ISceneLoader sceneLoader)
        {
            States = new Dictionary<Type, IExitableState>()
            {
                [typeof(MenuState)] = new MenuState(this, sceneLoader),
                [typeof(LoadGameState)] = new LoadGameState(this),
                [typeof(GameplayState)] = new GameplayState(this),
                [typeof(ResultState)] = new ResultState(this)
            };
        }
    }
}