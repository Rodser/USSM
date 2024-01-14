
namespace Game.Infrastructure.Interfaces.StateMaсhines
{
    public interface IStateMachine
    {
        object CurrentState { get; }
        void ChangeState(IState state);
    }
}