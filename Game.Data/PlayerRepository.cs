using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Data
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly GameDbContext gameDbContext;

        public PlayerRepository(GameDbContext gameDbContext)
        {
            this.gameDbContext = gameDbContext;
        }
        public IEnumerable<Player> GetAll()
        {

            return gameDbContext.Players.ToList();



        }

        public void Insert(Player player)
        {
            gameDbContext.Players.Add(player);

            gameDbContext.SaveChanges();
        }




    }
}
