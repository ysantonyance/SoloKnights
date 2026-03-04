using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Boss : BaseEntityWName
    {
        public int BiomeId { get; set; }
        public Biome Biome { get; set; }
    }
}
