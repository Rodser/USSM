using UnityEngine;

namespace Game.App
{
    public class AppFactory
    {
        public App Create()
        {
            return new GameObject(nameof(App)).AddComponent<App>();
        }
    }
}