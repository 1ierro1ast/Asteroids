using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Ui.Popups
{
    public class ResultPopup : BasePopup
    {
        [SerializeField] private Text _text;
        [field: SerializeField] public Button TryAgainButton { get; private set; }
        [field: SerializeField] public Button GoToMenuButton { get; private set; }

        public void SetTotalScore(int score)
        {
            _text.text = "Score: " + score;
        }
    }
}