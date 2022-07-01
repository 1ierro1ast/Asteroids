using System;
using Zenject;

namespace CodeBase.Infrastructure.Services
{
    public interface ISceneLoader : ITickable
    {
        public void LoadScene(string name, bool validateSceneName = true, Action onLoaded = null);
    }
}