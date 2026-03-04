using SoloKnights.Models.Enums;
using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Biome : BaseEntity
    {
        public BiomeType Type { get; set; }

        public int FloorId { get; set; }
        public virtual Floor? Floor { get; set; }

        public virtual ICollection<Boss>? Bosses { get; set; }
    }
}
