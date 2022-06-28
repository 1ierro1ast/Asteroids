using CodeBase.Ui.Popups;

namespace CodeBase.Infrastructure.Factories
{
    public interface IUiFactory
    {
        public OverlayPopup CreateOverlayPopup();
        public ResultPopup CreateResultPopup();
        public MenuPopup CreateMenuPopup();
    }
}