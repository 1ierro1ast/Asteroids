using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui.Popups;
using UnityEngine;
using Zenject;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class MenuState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        [Inject] private readonly IUiFactory _uiFactory;
        [Inject] private readonly ISceneLoader _sceneLoader;

        private MenuPopup _menuPopup;

        public MenuState(GameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            Debug.Log(_sceneLoader == null);
            //_sceneLoader.LoadScene("MenuScene", onLoaded: LinkStartButton);
        }

        private void LinkStartButton()
        {
            _menuPopup = _uiFactory.CreateMenuPopup();
            _menuPopup.PlayButton.onClick.AddListener(OnPlayButtonClick);
        }

        private void OnPlayButtonClick()
        {
            _gameStateMachine.Enter<LoadGameState>();
        }
    }
}