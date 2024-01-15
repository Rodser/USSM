using Game.Infrastructure.Interfaces.StateMaсhines;

namespace Game.Infrastructure.Interfaces.Services.Scenes
{
    public interface IScene : IState
    {
        string Name { get;}
    }
}