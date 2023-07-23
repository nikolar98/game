using Game.Data;

namespace Game.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository playerRepository;

        public PlayerService(IPlayerRepository playerRepository) {
            this.playerRepository = playerRepository;
        }


        public IEnumerable <Player> GetAll()
        {
            IEnumerable<Player> allPlayers = playerRepository.GetAll();

            return allPlayers;

        }

    }
}