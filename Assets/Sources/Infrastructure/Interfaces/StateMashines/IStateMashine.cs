
namespace Game.Infrastructure.Interfaces.StateMashines
{
    public interface IStateMashine
    {
        object CurrentState { get; }
        void ChangeState(IState state);
    }
}