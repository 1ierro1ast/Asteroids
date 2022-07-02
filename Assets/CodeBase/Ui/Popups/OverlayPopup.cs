using CodeBase.GamePlay.Player;
using CodeBase.Infrastructure.Services;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Ui.Popups
{
    public class OverlayPopup : BasePopup
    {
        [SerializeField] private Text _text;
        [SerializeField] public ProgressBar _progressBar;

        private IGameVariables _gameVariables;

        public void Initialize(IGameVariables gameVariables)
        {
            _gameVariables = gameVariables;

            _gameVariables.ChangeScoreEvent += GameVariablesOnChangeScoreEvent;
            Spaceship.ChangeHealth += SpaceshipOnChangeHealth;
        }

        private void SpaceshipOnChangeHealth(float healthPercent)
        {
            _progressBar.SetProgress(healthPercent);
        }

        private void GameVariablesOnChangeScoreEvent(int score)
        {
            SetScore(score);
        }

        private void OnDisable()
        {
            _gameVariables.ChangeScoreEvent -= GameVariablesOnChangeScoreEvent;
            Spaceship.ChangeHealth -= SpaceshipOnChangeHealth;
        }

        private void SetScore(int score)
        {
            _text.text = "Score: " + score;
        }
    }
}