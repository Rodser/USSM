using System;
using Game.Controllers.Interfaces;
using Game.Presentation.Interfaces;

namespace Game.Presentation.Implementations
{
    public class PresentableView<T> : View, IPresentableView<T> where T : IPresentor
    {
        protected T Presenter { get; private set; }

        private void OnEnable()
        {
            Presenter?.Enable();
        }

        private void OnDisable()
        {
            Presenter?.Disable();
        }

        public void Construct(T presentor)
        {
            if (presentor == null) 
                throw new ArgumentNullException(nameof(presentor));
            
            Hide();
            Presenter = presentor;
            Show();
        }
    }
}