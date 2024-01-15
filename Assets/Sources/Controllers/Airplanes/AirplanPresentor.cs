using Game.Domain;
using Game.Presentation.Interfaces;

namespace Game.Controllers.Airplanes
{
    public class AirplanPresentor
    {
        private readonly IAirplanView _view;
        private readonly Airplane _airplane;

        public AirplanPresentor(IAirplanView view, Airplane airplane)
        {
            _view = view;
            _airplane = airplane;
        }
    }
}