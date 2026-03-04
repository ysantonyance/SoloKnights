using SoloKnights.Models.MainModels;

namespace SoloKnights.Models.SupModels
{
    public class NPC : BaseEntityWName
    {
        public string Description { get; set; }

        public int LobbyId { get; set; }
        public Lobby Lobby { get; set; }
    }
}
