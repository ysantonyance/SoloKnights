using SoloKnights.Models.Enums;
using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Enemy : BaseEntityWName
    {
        public EnemyCategory Category { get; set; }
        public int LevelId { get; set; }
        public virtual Level? Level { get; set; }
    }
}
