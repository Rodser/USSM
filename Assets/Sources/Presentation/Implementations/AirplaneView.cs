using Game.Controllers.Implementations.Airplanes;
using Game.Presentation.Interfaces;
using UnityEngine;

namespace Game.Presentation.Implementations
{
    public class AirplaneView : PresentableView<AirplanPresentor>, IAirplanView
    {
        public void SetPosition(Vector2 position)
        {
            // TODO: Vector2 to Vector3 ??? 2D or 3D  
            transform.position = new Vector3(position.x, 0, position.y);
        }
    }
}