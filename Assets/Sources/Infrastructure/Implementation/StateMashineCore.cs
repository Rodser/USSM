using Game.Infrastructure.Interfaces.StateMashines;

namespace Game.Infrastructure.Implementation
{
    public class StateMashineCore : IStateMashine
    {
        public object CurrentState { get; private set; }

        public void ChangeState(IState state)
        {
            CurrentState = state;
        }
    }
}