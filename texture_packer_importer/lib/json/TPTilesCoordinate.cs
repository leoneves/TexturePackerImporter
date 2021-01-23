using Newtonsoft.Json;

namespace TPTileMapPipeline
{
    public class TPTileCoordinatesJson
    {
        [JsonProperty("tiles")]
        public TPTileCoordinatesJson[] Tiles { get; set; }
    }

    public class TPTileMapCoordinates
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("anchor")]
        public Anchor Anchor { get; set; }
    }

    public class Anchor
    {
        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }
    }
}
