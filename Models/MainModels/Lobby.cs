using SoloKnights.Models.SupModels;

namespace SoloKnights.Models.MainModels
{
    public class Lobby : BaseEntityWName
    {
        public string Description { get; set; }

        public ICollection<GameObject> Objects { get; set; }
        public ICollection<NPC> NPCs { get; set; }
    }
}
