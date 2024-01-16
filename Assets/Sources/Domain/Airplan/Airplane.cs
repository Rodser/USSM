using System;
using UnityEngine;

namespace Game.Domain.Airplan
{
    public class Airplane
    {
        public event Action PositionChanged;
        
        public Vector2 Position { get; private set; }
        public int Lives { get; private set; }

        protected virtual void OnPositionChanged()
        {
            PositionChanged?.Invoke();
        }
    }
}