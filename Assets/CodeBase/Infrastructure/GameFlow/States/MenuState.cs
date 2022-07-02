using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui;
using CodeBase.Ui.Popups;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class MenuState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IUiFactory _uiFactory;
        private readonly LoadingCurtain _loadingCurtain;
        private readonly ISceneLoader _sceneLoader;

        private MenuPopup _menuPopup;

        public MenuState(GameStateMachine gameStateMachine, ISceneLoader sceneLoader, IUiFactory uiFactory,
            LoadingCurtain loadingCurtain)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
            _uiFactory = uiFactory;
            _loadingCurtain = loadingCurtain;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            _sceneLoader.LoadScene("MenuScene", onLoaded: LinkStartButton);
        }

        private void LinkStartButton()
        {
            _menuPopup = _uiFactory.CreateMenuPopup();
            _menuPopup.PlayButton.onClick.AddListener(OnPlayButtonClick);
            _loadingCurtain.Close();
        }

        private void OnPlayButtonClick()
        {
            _gameStateMachine.Enter<LoadGameState>();
        }
    }
}