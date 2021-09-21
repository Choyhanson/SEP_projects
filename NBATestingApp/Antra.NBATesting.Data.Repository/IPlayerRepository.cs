using System;
using System.Collections.Generic;
using System.Text;
using Antra.NBATestingApp.Data.Model;

namespace Antra.NBATestingApp.Data.Repository
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetPlayersByTeamId(int teamId);
    }
}
