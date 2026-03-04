using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class CharacterSkill : BaseEntityWName
    {
        public string Description { get; set; }
        public string Img { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
