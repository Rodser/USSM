using UnityEngine;

namespace Game.App
{
    public class App : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            Log.Print(nameof(App));
        }
    }
}
