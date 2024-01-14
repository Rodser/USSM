using System;
using System.Collections.Generic;
using Game.Infrastructure.Interfaces.Factories.Scenes;
using Game.Infrastructure.Interfaces.Services.Scenes;
using Game.Infrastructure.Interfaces.StateMashines;

namespace Game.Infrastructure.Implementation.Scenes
{
    public class SceneStateMashineService : ISceneStateMashineService
    {
        private readonly IStateMashine _stateMashine;
        private readonly IReadOnlyDictionary<Type, ISceneFactory> _sceneFactories;
        private readonly UpdatableStateMashine _updatableStateMashine;

        public SceneStateMashineService(IStateMashine stateMashine, IReadOnlyDictionary<Type, ISceneFactory> sceneFactories)
        {
            _stateMashine = stateMashine;
            _sceneFactories = sceneFactories;
            _updatableStateMashine = new UpdatableStateMashine(stateMashine);
        }
        
        public void ChangeScene<T>() where T : IScene
        {
            if (_sceneFactories.TryGetValue(typeof(T), out ISceneFactory factory) == false)
                throw new InvalidOperationException();
            
            IState state = factory.Create();
            _stateMashine.ChangeState(state);
        }
        
        public void Update()
        {
            _updatableStateMashine.Update();
        }
    }
}