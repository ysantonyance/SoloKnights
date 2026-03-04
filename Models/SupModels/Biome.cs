using SoloKnights.Models.Enums;
using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Biome : BaseEntity
    {
        public BiomeType Type { get; set; }

        public int FloorId { get; set; }
        public Floor Floor { get; set; }

        public ICollection<Boss> Bosses { get; set; }
    }
}
