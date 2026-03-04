using SoloKnights.Models.MainModels;
using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.SupModels
{
    public class Skin : BaseEntityWName
    {
        public string Img { get; set; }
        public int PriceId { get; set; }
        public virtual Price? Price { get; set; }

        public int CharacterId { get; set; }
        public virtual Character? Character { get; set; }
    }
}
