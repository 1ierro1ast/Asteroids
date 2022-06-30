using CodeBase.Infrastructure.Services;
using CodeBase.Ui.Popups;
using Zenject;

namespace CodeBase.Infrastructure.Factories
{
    public class UiFactory : IUiFactory
    {
        private readonly IAssetProvider _assetProvider;

        [Inject]
        public UiFactory(IAssetProvider assetProvider)
        {
            _assetProvider = assetProvider;
        }
        
        public OverlayPopup CreateOverlayPopup()
        {
            return _assetProvider.Instantiate<OverlayPopup>(AssetPath.OverlayPopupPath);
        }

        public ResultPopup CreateResultPopup()
        {
            return _assetProvider.Instantiate<ResultPopup>(AssetPath.ResultPopupPath);
        }

        public MenuPopup CreateMenuPopup()
        {
            return _assetProvider.Instantiate<MenuPopup>(AssetPath.MenuPopupPath);
        }
    }
}