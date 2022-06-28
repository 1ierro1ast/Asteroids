using System;

namespace CodeBase.Infrastructure.Services
{
    public interface IGameVariables
    {
        event Action<int> ChangeHighScoreEvent;
        event Action<int> ChangeScoreEvent;
        int HighScore { get; }
        int Score { get; }

        public void ClearScore();
        public void AddScores(int amount = 1);
    }
}