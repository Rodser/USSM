using Game.Infrastructure.Interfaces.StateMaсhines;

namespace Game.Infrastructure.Implementation.StateMachines
{
    public class StateMachineCore : IStateMachine
    {
        public object CurrentState { get; private set; }

        public void ChangeState(IState state)
        {
            CurrentState = state;
        }
    }
}