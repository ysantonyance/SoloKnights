using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Floor : BaseEntity
    {
        public int Number {  get; set; }

        public ICollection<Biome> Biomes { get; set; }
        public ICollection<Level> Levels { get; set; }
        public ICollection<Enemy> Enemies { get; set; }
        public ICollection<Boss> Bosses { get; set; }
    }
}
