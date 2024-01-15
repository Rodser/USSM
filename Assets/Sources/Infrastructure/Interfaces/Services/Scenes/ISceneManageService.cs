using Cysharp.Threading.Tasks;

namespace Game.Infrastructure.Interfaces.Services.Scenes
{
    public interface ISceneManageService
    {
        UniTask LoadSceneAsync(string nameScene);
    }
}