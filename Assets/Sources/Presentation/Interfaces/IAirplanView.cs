using UnityEngine;

namespace Game.Presentation.Interfaces
{
    public interface IAirplanView : IView
    {
        void SetPosition(Vector2 position);
    }
}