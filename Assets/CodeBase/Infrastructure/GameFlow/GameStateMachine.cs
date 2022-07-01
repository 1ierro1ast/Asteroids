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
        public GameStateMachine(ISceneLoader sceneLoader, IUiFactory uiFactory, LoadingCurtain loadingCurtain)
        {
            States = new Dictionary<Type, IExitableState>()
            {
                [typeof(MenuState)] = new MenuState(this, sceneLoader, uiFactory),
                [typeof(LoadGameState)] = new LoadGameState(this, sceneLoader, loadingCurtain),
                [typeof(GameplayState)] = new GameplayState(this, loadingCurtain),
                [typeof(ResultState)] = new ResultState(this)
            };
        }
    }
}