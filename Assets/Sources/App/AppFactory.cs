using System;
using System.Collections.Generic;
using Game.Controllers.Scenes;
using Game.Infrastructure.Implementation.Factories.Scenes;
using Game.Infrastructure.Implementation.Services.Scenes;
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

            var stateMaсhine = new StateMachineCore();
            var sceneManageService = new SceneManageService(); 
            
            var sceneFactories = new Dictionary<Type, ISceneFactory>()
            {
                [typeof(GameMenuScene)] = new GameMenuSceneFactory(sceneManageService),
                
            };

            var sceneService = new SceneStateMachineService(stateMaсhine, sceneFactories);
            app.Construct(sceneService);
            
            return app;
        }

        private App CreateApp()
        {
            return new GameObject(nameof(App)).AddComponent<App>();
        }
    }
}