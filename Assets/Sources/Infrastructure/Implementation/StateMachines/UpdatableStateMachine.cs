using Game.Infrastructure.Interfaces.Services;
using Game.Infrastructure.Interfaces.StateMaсhines;

namespace Game.Infrastructure.Implementation.StateMachines
{
    public class UpdatableStateMachine : IStateMachine, IUpdatable
    {
        private readonly IStateMachine _stateMachine;
        
        public object CurrentState => _stateMachine.CurrentState;

        public UpdatableStateMachine(IStateMachine stateMachine)
        {
            _stateMachine = stateMachine;
        }
        
        public void ChangeState(IState state)
        {
            _stateMachine.ChangeState(state);
        }

        public void Update()
        {
            (CurrentState as IUpdatable)?.Update();
        }
    }
}