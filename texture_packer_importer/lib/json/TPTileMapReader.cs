using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Content;
using Newtonsoft.Json;

namespace TPTileMapPipeline
{
    public class TPTileMapReader : ContentTypeReader<TPTileCoordinatesJson>
    {
        protected override TPTileCoordinatesJson Read(ContentReader input, TPTileCoordinatesJson existingInstance)
        {
            var json = input.ReadString();
            using (var stringReader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<TPTileCoordinatesJson>(jsonReader);
            }

            // return JsonConvert.DeserializeObject<TPTileCoordinatesJson>(input.ReadString());
        }
    }
}
