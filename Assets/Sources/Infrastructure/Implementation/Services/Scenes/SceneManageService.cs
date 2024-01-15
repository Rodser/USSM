using Cysharp.Threading.Tasks;
using Game.Infrastructure.Interfaces.Services.Scenes;
using UnityEngine.SceneManagement;

namespace Game.Infrastructure.Implementation.Services.Scenes
{
    public class SceneManageService : ISceneManageService
    {
        public async UniTask LoadSceneAsync(string nameScene)
        {
            await SceneManager.LoadSceneAsync(nameScene).ToUniTask();
        }
    }
}