using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Floor : BaseEntity
    {
        public int Number {  get; set; }

        public virtual ICollection<Biome>? Biomes { get; set; }
        public virtual ICollection<Level>? Levels { get; set; }
        public virtual ICollection<Enemy>? Enemies { get; set; }
        public virtual ICollection<Boss>? Bosses { get; set; }
    }
}
