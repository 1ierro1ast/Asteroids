using System;
using System.Collections.Generic;
using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.GameFlow.States;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui;
using Zenject;

namespace CodeBase.Infrastructure.GameFlow
{
    public class GameStateMachine : BaseStateMachine, IGameStateMachine
    {
        [Inject]
        public GameStateMachine(ISceneLoader sceneLoader, IUiFactory uiFactory, LoadingCurtain loadingCurtain,
            IGameVariables gameVariables)
        {
            States = new Dictionary<Type, IExitableState>()
            {
                [typeof(MenuState)] = new MenuState(this, sceneLoader, uiFactory, loadingCurtain, gameVariables),
                [typeof(LoadGameState)] = new LoadGameState(this, sceneLoader, loadingCurtain),
                [typeof(GameplayState)] = new GameplayState(this, loadingCurtain, uiFactory, gameVariables),
                [typeof(ResultState)] = new ResultState(this, uiFactory, gameVariables)
            };
        }
    }
}