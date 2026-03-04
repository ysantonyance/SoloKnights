using SoloKnights.Models.SupModels;
using System.ComponentModel.DataAnnotations;

namespace SoloKnights.Models.MainModels
{
    public class Character : BaseEntityWName
    {
        public int Hp {  get; set; }
        public int Armor { get; set; }
        public int CritChance { get; set; }
        public int Dmg {  get; set; }
        public int Speed { get; set; }
        public virtual StarterWeapon? StarterWeapon { get; set; }
        public int PassiveId { get; set; }
        public virtual Buff? Passive {  get; set; }
        public int PriceId { get; set; }
        public virtual Price? Price { get; set; }

        public virtual ICollection<CharacterSkill>? Skills { get; set; }
        public virtual ICollection<Skin>? Skins { get; set; }
    }
}
