using Game.Presentation.Interfaces;
using UnityEngine;

namespace Game.Presentation.Implementations
{
    public class View : MonoBehaviour, IView
    {
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}