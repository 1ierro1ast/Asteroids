using CodeBase.GamePlay.Player;
using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui;
using CodeBase.Ui.Popups;
using UnityEngine;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class GameplayState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly LoadingCurtain _loadingCurtain;
        private readonly IUiFactory _uiFactory;
        private readonly IGameVariables _gameVariables;
        private OverlayPopup _overlayPopup;

        public GameplayState(GameStateMachine gameStateMachine, LoadingCurtain loadingCurtain, IUiFactory uiFactory, IGameVariables gameVariables)
        {
            _gameStateMachine = gameStateMachine;
            _loadingCurtain = loadingCurtain;
            _uiFactory = uiFactory;
            _gameVariables = gameVariables;
        }

        public void Exit()
        {
            Spaceship.SpaceshipDestroyed -= SpaceshipOnSpaceshipDestroyed;
            
            _overlayPopup.Close();
        }

        public void Enter()
        {
            Spaceship.SpaceshipDestroyed += SpaceshipOnSpaceshipDestroyed;
            _overlayPopup = _uiFactory.CreateOverlayPopup();
            _overlayPopup.Initialize(_gameVariables);
            _loadingCurtain.Close();
        }

        private void SpaceshipOnSpaceshipDestroyed()
        {
            _gameStateMachine.Enter<ResultState>();
        }
    }
}