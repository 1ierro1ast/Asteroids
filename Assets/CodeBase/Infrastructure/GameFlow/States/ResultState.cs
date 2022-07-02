using CodeBase.Infrastructure.Factories;
using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui.Popups;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class ResultState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly IUiFactory _uiFactory;
        private readonly IGameVariables _gameVariables;

        private ResultPopup _resultPopup;

        public ResultState(GameStateMachine gameStateMachine, IUiFactory uiFactory, IGameVariables gameVariables)
        {
            _gameStateMachine = gameStateMachine;
            _uiFactory = uiFactory;
            _gameVariables = gameVariables;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            _resultPopup = _uiFactory.CreateResultPopup();
            _resultPopup.SetTotalScore(_gameVariables.Score);
            _resultPopup.TryAgainButton.onClick.AddListener(OnTryAgainButtonClick);
            _resultPopup.GoToMenuButton.onClick.AddListener(OnGoToMenuButtonClick);
        }

        private void OnGoToMenuButtonClick()
        {
            _gameStateMachine.Enter<MenuState>();
        }

        private void OnTryAgainButtonClick()
        {
            _gameStateMachine.Enter<LoadGameState>();
        }
    }
}