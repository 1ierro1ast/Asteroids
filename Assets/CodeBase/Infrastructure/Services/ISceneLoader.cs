using System;

namespace CodeBase.Infrastructure.Services
{
    public interface ISceneLoader
    {
        public void LoadScene(string name, bool validateSceneName = true, Action onLoaded = null);
    }
}