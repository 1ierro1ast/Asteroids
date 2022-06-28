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
            throw new System.NotImplementedException();
        }

        public ResultPopup CreateResultPopup()
        {
            throw new System.NotImplementedException();
        }

        public MenuPopup CreateMenuPopup()
        {
            throw new System.NotImplementedException();
        }
    }
}