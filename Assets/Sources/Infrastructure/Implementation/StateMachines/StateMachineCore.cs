using Game.Infrastructure.Interfaces.StateMaсhines;

namespace Game.Infrastructure.Implementation.StateMachines
{
    public class StateMachineCore : IStateMachine
    {
        private IState _currentState;
        public object CurrentState => _currentState;

        public void ChangeState(IState state)
        {
            _currentState?.Exit();
            _currentState = state;
            _currentState?.Enter();
        }
    }
}