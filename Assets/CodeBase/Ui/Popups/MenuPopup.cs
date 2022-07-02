using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Ui.Popups
{
    public class MenuPopup : BasePopup
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private Text _highScoreText;
        public Button PlayButton => _playButton;

        public void SetHignScore(int highScore)
        {
            _highScoreText.text = "Highscore: " + highScore;
        }
    }
}