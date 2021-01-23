using System.IO;
using Microsoft.Xna.Framework.Content.Pipeline;
using Newtonsoft.Json;

namespace TPTileMapPipeline
{
    [ContentImporter(".json", DefaultProcessor = "TPTileMapProcessor", DisplayName = "Tileset Map Importer")]
    public class TPTileMapImporter : ContentImporter<string>
    {
        public override string Import(string filename, ContentImporterContext context)
        {
            context.Logger.LogMessage("Importing JSON map: {0}", filename);
            return File.ReadAllText(filename);
        }
    }
}
