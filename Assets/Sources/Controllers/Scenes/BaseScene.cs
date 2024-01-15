using Game.Infrastructure.Interfaces.Services.Scenes;

namespace Game.Controllers.Scenes
{
    public abstract class BaseScene : IScene
    {
        public virtual void Enter()
        {
        }

        public virtual void Exit()
        {
        }

        public abstract string Name { get; }
    }
}