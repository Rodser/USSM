using Game.Domain.Airplan;
using Game.Presentation.Interfaces;

namespace Game.Controllers.Implementations.Airplanes
{
    public class AirplanPresentor : PresentorBase
    {
        private readonly IAirplanView _view;
        private readonly Airplane _airplane;

        public AirplanPresentor(IAirplanView view, Airplane airplane)
        {
            _view = view;
            _airplane = airplane;
        }
        
        public override void Enable()
        {
            _airplane.PositionChanged += OnPositionChanged;
        }

        public override void Disable()
        {        
            _airplane.PositionChanged -= OnPositionChanged;
        }

        private void OnPositionChanged()
        {
            _view.SetPosition(_airplane.Position);
        }
    }
}