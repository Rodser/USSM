using Unity.Plastic.Newtonsoft.Json;

namespace Game.Domain
{
    public class Vector2Data
    {
        [JsonProperty("x")] public float X { get; set; }
        [JsonProperty("y")] public float Y { get; set; }
    }
}