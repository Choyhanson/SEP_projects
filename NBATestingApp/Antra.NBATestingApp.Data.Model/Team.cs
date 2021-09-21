using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.NBATestingApp.Data.Model
{
    public class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public decimal Capital { get; set; }
        private List<Player> players = new List<Player>();
        public List <Player> Players{
            get
            { return players; }
            set {
                players = value;
            } }
    }
}
