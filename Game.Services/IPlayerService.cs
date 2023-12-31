﻿using Game.Data;

namespace Game.Services
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetAll();
        void Insert(Player player);
    }
}