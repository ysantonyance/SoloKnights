using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Lobby : BaseEntityWName
    {
        public string Description { get; set; }

        public virtual ICollection<GameObject>? Objects { get; set; }
        public virtual ICollection<NPC>? NPCs { get; set; }
    }
}
