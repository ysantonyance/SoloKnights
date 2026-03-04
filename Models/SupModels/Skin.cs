using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Skin : BaseEntityWName
    {
        public string Img { get; set; }
        public int PriceId { get; set; }
        public Price Price { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
