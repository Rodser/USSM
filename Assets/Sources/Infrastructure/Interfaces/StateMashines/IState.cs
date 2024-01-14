
namespace Game.Infrastructure.Interfaces.StateMashines
{
    public interface IState 
    { 
        void Enter ();
        void Exit ();
    }
}