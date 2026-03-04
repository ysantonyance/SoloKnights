using SoloKnights.Models.Enums;
using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Weapon : BaseEntityWName
    {
        public WeaponType Type { get; set; }
        public int Dmg { get; set; }
        public int EnergyCost { get; set; }
        public int CritChance { get; set; }
        public int Inaccuracy { get; set; }
        public int RarityId { get; set; }
        public virtual Rarity? Rarity { get; set; }
    }
}
