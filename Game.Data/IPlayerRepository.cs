namespace Game.Data
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAll();
    }
}