using Game.Controllers.Interfaces;

namespace Game.Presentation.Interfaces
{
    public interface IPresentableView<in T> where T : IPresentor
    {
        void Construct(T presentor);
    }
}