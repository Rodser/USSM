using Game.Infrastructure.Interfaces.Services.Scenes;
using UnityEngine;

namespace Game.App
{
    public class App : MonoBehaviour
    {
        private ISceneStateMashineService _sceneService;

        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            Log.Print(nameof(App));
        }

        private void Update()
        {
            _sceneService.Update();
        }

        public void Construct(ISceneStateMashineService sceneService)
        {
            _sceneService = sceneService;
        }
    }
}
