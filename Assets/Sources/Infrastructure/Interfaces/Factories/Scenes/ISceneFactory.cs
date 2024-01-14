using Game.Infrastructure.Interfaces.StateMashines;

namespace Game.Infrastructure.Interfaces.Factories.Scenes
{
    public interface ISceneFactory
    {
        IState Create();
    }
}