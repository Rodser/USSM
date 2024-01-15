using Game.Infrastructure.Interfaces.Services.Scenes;

namespace Game.Controllers.Scenes
{
    public class GameMenuScene : BaseScene
    {
        private readonly ISceneChanger _sceneChanger;
        private readonly ISceneManageService _sceneManageService;

        public GameMenuScene(ISceneChanger sceneChanger, ISceneManageService sceneManageService)
        {
            _sceneChanger = sceneChanger;
            _sceneManageService = sceneManageService;
        }

        public override string Name { get; } = nameof(GameMenuScene);

        public override void Enter()
        {
            Log.Print(Name);
        }
    }
}