using Game.Infrastructure.Implementation;
using UnityEngine;

namespace Game.App
{
    public class AppFactory
    {
        public App Create()
        {
            var app = CreateApp();

            var stateMashine = new StateMashineCore();
            
            return app;
        }

        private App CreateApp()
        {
            return new GameObject(nameof(App)).AddComponent<App>();
        }
    }
}