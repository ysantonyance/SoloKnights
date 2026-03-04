using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Character : BaseEntityWName
    {
        public int Hp {  get; set; }
        public int Armor { get; set; }
        public int CritChance { get; set; }
        public int Dmg {  get; set; }
        public int Speed { get; set; }
        public StarterWeapon StarterWeapon { get; set; }
        public int PassiveId { get; set; }
        public Buff Passive {  get; set; }
        public int PriceId { get; set; }
        public Price Price { get; set; }

        public ICollection<CharacterSkill> Skills { get; set; }
        public ICollection<Skin> Skins { get; set; }
    }
}
