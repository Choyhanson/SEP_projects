using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.NBATestingApp.Data.Model
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        //public int TeamId { get; set; }
        public Team Teams { get; set; }
    }
}
