using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Statue : BaseEntityWName
    {
        public int Cd {  get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Interactions { get; set; }
        public int PriceId { get; set; }
        public virtual Price? Price { get; set; }
    }
}
