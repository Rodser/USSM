using UnityEngine;

namespace Game.App.Entrypoint
{
    [DefaultExecutionOrder(-1)]
    public class Bootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            if (FindFirstObjectByType<App>() == null)
            {
                new AppFactory().Create();
            }
        }
    }
}
