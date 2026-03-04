using SoloKnights.Models.Enums;

namespace SoloKnights.Models.SupModels
{
    public class Price : BaseEntity
    {
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
    }
}
