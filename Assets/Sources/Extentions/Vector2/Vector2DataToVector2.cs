using Game.Domain;
using vector2 = UnityEngine.Vector2;

namespace Game.Extentions.Vector2
{ 
        public static partial class Vector2Extentions
        {
            public static vector2 Vector2DataToVector2(this Vector2Data vector)
            {
                return new vector2(vector.X, vector.Y);
            }
        }
    
}