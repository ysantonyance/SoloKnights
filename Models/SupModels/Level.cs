using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class Level : BaseEntity
    {
        public decimal Number {  get; set; }

        public int FloorId { get; set; }
        public virtual Floor? Floor { get; set; }

        public virtual ICollection<Enemy>? Enemies { get; set; }
    }
}
