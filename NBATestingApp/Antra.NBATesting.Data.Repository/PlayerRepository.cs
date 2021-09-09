using Antra.NBATestingApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Antra.NBATestingApp.Data.Repository
{
    public class PlayerRepository : IRepository<Player>
    {
        DBHelper db;
        public PlayerRepository()
        {
            db = new DBHelper();
        }
        public int Delete(int id)
        {
            string cmd = @"delete from NBATeamPlayer where PlayerId=@playerId";
            Dictionary<string, object> t = new Dictionary<string, object>();
            t.Add("@playerId", id);
            return db.Execute(cmd, t);
        }

        public IEnumerable<Player> GetAll()
        {
            string cmd = @"select n.PlayerId,n.PlayerName,T.TeamId,t.TeamName
                        from NBATeamPlayer n join team t on n.TeamId=t.TeamId
                        order by 3,2";
            DataTable dt = db.Query(cmd, null);
            if (dt!=null)
            {
                List<Player> playerCollection = new List<Player>();
                foreach (DataRow item in dt.Rows)
                {
                    Player p = new Player();
                    p.PlayerId = Convert.ToInt32(item["PlayerId"]);
                    p.PlayerName = Convert.ToString(item["PlayerName"]);
                    //p.TeamId = Convert.ToInt32(item["TeamId"]);
                    Team t = new Team();
                    p.Teams = t;
                    p.Teams.TeamId = Convert.ToInt32(item["TeamId"]);
                    p.Teams.TeamName = Convert.ToString(item["TeamName"]);
                    playerCollection.Add(p);
                }
                return playerCollection;
            }
            return null;
        }

        public List<Player> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Player item)
        {
            string cmd = @"Insert into NBATeamPlayer values(@playerId,@playerName,@teamId)";
            Dictionary<string, object> t = new Dictionary<string, object>();
            t.Add("@playerName", item.PlayerName);
            t.Add("@teamId", item.Teams.TeamId);
            t.Add("@playerId", item.PlayerId);
            return db.Execute(cmd, t);
        }

        public int Update(Player item)
        {
            string cmd = @"Update NBATeamPlayer set PlayerName=@playerName, TeamId=@TeamId where PlayerId=@playerId";
            Dictionary<string, object> t = new Dictionary<string, object>();
            t.Add("@playerName", item.PlayerName);
            t.Add("@teamId", item.Teams.TeamId);
            t.Add("@playerId", item.PlayerId);
            return db.Execute(cmd, t);
        }
    }
}
