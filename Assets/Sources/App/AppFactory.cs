using System;
using System.Collections.Generic;
using Game.Infrastructure.Implementation;
using Game.Infrastructure.Implementation.Scenes;
using Game.Infrastructure.Implementation.StateMachines;
using Game.Infrastructure.Interfaces.Factories.Scenes;
using UnityEngine;

namespace Game.App
{
    public class AppFactory
    {
        public App Create()
        {
            var app = CreateApp();

            var stateMashine = new StateMachineCore();
            
            var sceneFactories = new Dictionary<Type, ISceneFactory>()
            {
                
            };

            var sceneService = new SceneStateMachineService(stateMashine, sceneFactories);
            app.Construct(sceneService);
            
            return app;
        }

        private App CreateApp()
        {
            return new GameObject(nameof(App)).AddComponent<App>();
        }
    }
}