using System;
using System.Collections.Generic;
using System.Text;
using Antra.NBATestingApp.Data.Model;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using Dapper;

namespace Antra.NBATestingApp.Data.Repository
{
    public class TeamRepository : IRepository<Team>
    {
        DBHelper db;
        public TeamRepository()
        {
            db = new DBHelper();
        }
        public int Delete(int id)
        {
            string cmd = @"delete from Team where TeamId=@teamId";
            Dictionary<string, object> t = new Dictionary<string, object>();
            t.Add("@teamId", id);
            return db.Execute(cmd, t);
        }

        public IEnumerable<Team> GetAll()
        {
            string cmd = "select TeamId,TeamName ,Capital from Team";
            DataTable dt = db.Query(cmd, null);
            List<Team> teamCollection = new List<Team>();
            if (dt!=null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Team t = new Team();
                    t.TeamId = Convert.ToInt32(item["teamid"]);
                    t.TeamName = Convert.ToString(item["TeamName"]);
                    t.Capital = Convert.ToDecimal(item["Capital"]);
                    teamCollection.Add(t);
                }
                return teamCollection;
            }
            return null;
        }

        public List<Team> GetById(int id)
        {
            string cmd = $"select TeamId,TeamName from Team where Teamid={id}";
            DataTable dt = db.Query(cmd, null);
            List<Team> teamCollection = new List<Team>();
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Team t = new Team();
                    t.TeamId = Convert.ToInt32(item["TeamId"]);
                    t.TeamName = Convert.ToString(item["TeamName"]);
                    teamCollection.Add(t);
                }
                return teamCollection;
            }
            return null;
        }
        
        public int Insert(Team item)
        {
            //string cmd = @"Insert into Team values(@teamName)";
            //Dictionary<string, object> t = new Dictionary<string, object>();
            //t.Add("@teamName", item.TeamName);
            //return db.Execute(cmd, t);
            IDbConnection con = db.GetConnection();
            return con.Execute("insert into team (TeamName)values(@TeamName)", item);
        }

        public int Update(Team item)
        {
            string cmd = @"Update Team set TeamName=@teamName where TeamId=@teamId";
            Dictionary<string, object> t = new Dictionary<string, object>();
            t.Add("@teamName", item.TeamName);
            t.Add("@teamId", item.TeamId);
            return db.Execute(cmd, t);
        }
    }
}
