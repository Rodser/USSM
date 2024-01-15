using System;
using System.Collections.Generic;
using Game.Infrastructure.Implementation.StateMachines;
using Game.Infrastructure.Interfaces.Factories.Scenes;
using Game.Infrastructure.Interfaces.Services.Scenes;
using Game.Infrastructure.Interfaces.StateMaсhines;

namespace Game.Infrastructure.Implementation.Services.Scenes
{
    public class SceneStateMachineService : ISceneStateMachineService
    {
        private readonly IStateMachine _stateMachine;
        private readonly IReadOnlyDictionary<Type, ISceneFactory> _sceneFactories;
        private readonly UpdatableStateMachine _updatableStateMachine;

        public SceneStateMachineService(IStateMachine stateMachine, IReadOnlyDictionary<Type, ISceneFactory> sceneFactories)
        {
            _stateMachine = stateMachine;
            _sceneFactories = sceneFactories;
            _updatableStateMachine = new UpdatableStateMachine(stateMachine);
        }
        
        public void ChangeScene<T>() where T : IScene
        {
            if (_sceneFactories.TryGetValue(typeof(T), out ISceneFactory factory) == false)
                throw new InvalidOperationException();
            
            IState state = factory.Create(this);
            _stateMachine.ChangeState(state);
        }
        
        public void Update()
        {
            _updatableStateMachine.Update();
        }
    }
}