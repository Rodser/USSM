using Game.Controllers.Scenes;
using Game.Infrastructure.Interfaces.Factories.Scenes;
using Game.Infrastructure.Interfaces.Services.Scenes;

namespace Game.Infrastructure.Implementation.Factories.Scenes
{
    public class GameMenuSceneFactory : ISceneFactory
    {
        private readonly ISceneManageService _sceneManageService;

        public GameMenuSceneFactory(ISceneManageService sceneManageService)
        {
            _sceneManageService = sceneManageService;
        }

        public IScene Create(ISceneChanger sceneChanger)
        {
            return new GameMenuScene(sceneChanger, _sceneManageService);
        }
    }
}