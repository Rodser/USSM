using Game.Infrastructure.Interfaces.StateMaсhines;

namespace Game.Infrastructure.Interfaces.Factories.Scenes
{
    public interface ISceneFactory
    {
        IState Create();
    }
}