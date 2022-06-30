using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Ui.Popups
{
    public class MenuPopup : BasePopup
    {
        [SerializeField] private Button _playButton;
        public Button PlayButton => _playButton;
    }
}