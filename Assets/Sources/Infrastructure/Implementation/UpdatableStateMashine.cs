using Game.Infrastructure.Interfaces.Services;
using Game.Infrastructure.Interfaces.StateMashines;

namespace Game.Infrastructure.Implementation
{
    public class UpdatableStateMashine : IStateMashine, IUpdatable
    {
        private readonly IStateMashine _stateMashine;
        
        public object CurrentState => _stateMashine.CurrentState;

        public UpdatableStateMashine(IStateMashine stateMashine)
        {
            _stateMashine = stateMashine;
        }
        
        public void ChangeState(IState state)
        {
            _stateMashine.ChangeState(state);
        }

        public void Update()
        {
            (CurrentState as IUpdatable)?.Update();
        }
    }
}