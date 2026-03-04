using SoloKnights.Models.Enums;

namespace SoloKnights.Models.MainModels
{
    public class Buff : BaseEntityWName
    {
        public string Description { get; set; }
        public BuffType Type { get; set; }
    }
}
