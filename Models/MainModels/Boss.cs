using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Boss : BaseEntityWName
    {
        public int BiomeId { get; set; }
        public virtual Biome? Biome { get; set; }
    }
}
