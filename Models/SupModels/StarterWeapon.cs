using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class StarterWeapon : Weapon
    {
        public int CharacterId { get; set; }
        public virtual Character? Character { get; set; }
    }
}
