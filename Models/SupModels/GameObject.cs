using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class GameObject : BaseEntityWName
    {
        public string Description { get; set; }

        public int LobbyId { get; set; }
        public virtual Lobby? Lobby { get; set; }
    }
}
