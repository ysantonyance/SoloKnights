using SoloKnights.Models.Enums;
using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Rarity : BaseEntity
    {
        public RarityLevel Level { get; set; }
        public ItemColor Color { get; set; }

        public virtual ICollection<Weapon>? Weapons { get; set; }
    }
}
