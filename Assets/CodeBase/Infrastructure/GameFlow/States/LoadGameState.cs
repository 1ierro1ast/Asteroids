using CodeBase.Infrastructure.Services;
using CodeBase.Infrastructure.StateMachine;
using CodeBase.Ui;

namespace CodeBase.Infrastructure.GameFlow.States
{
    public class LoadGameState : IState
    {
        private readonly GameStateMachine _gameStateMachine;
        private readonly ISceneLoader _sceneLoader;
        private readonly LoadingCurtain _loadingCurtain;

        public LoadGameState(GameStateMachine gameStateMachine, ISceneLoader sceneLoader, LoadingCurtain loadingCurtain)
        {
            _gameStateMachine = gameStateMachine;
            _sceneLoader = sceneLoader;
            _loadingCurtain = loadingCurtain;
        }

        public void Exit()
        {
        }

        public void Enter()
        {
            //_loadingCurtain.Open();
            _sceneLoader.LoadScene("GameScene", onLoaded: LoadSceneCallback);
        }

        private void LoadSceneCallback()
        {
            _gameStateMachine.Enter<GameplayState>();
        }
    }
}