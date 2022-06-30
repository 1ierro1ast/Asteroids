using System;

namespace CodeBase.Infrastructure.Services
{
    public sealed class GameVariables : IGameVariables
    {
        private readonly ISaveLoadService _saveLoadService;
        
        private const string HighScoreSaveKey = "HighScore";
        
        private int _highScore;
        private int _score;
        
        public event Action<int> ChangeHighScoreEvent;
        public event Action<int> ChangeScoreEvent;
        
        public GameVariables(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
            LoadData();
        }

        public int HighScore => _highScore;

        public int Score => _score;

        private void LoadData()
        {
            _highScore = _saveLoadService.LoadInt(HighScoreSaveKey, 0);
        }

        public void ClearScore()
        {
            _score = 0;
        }

        public void AddScores(int amount = 1)
        {
            _score += amount;
            ChangeScoreEvent?.Invoke(_score);
            CompareHighScore();
        }

        private void CompareHighScore()
        {
            if (_score > _highScore)
            {
                _highScore = _score;
                _saveLoadService.SaveInt(HighScoreSaveKey, _highScore);
                ChangeHighScoreEvent?.Invoke(_highScore);
            }
        }
    }
}