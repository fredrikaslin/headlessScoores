using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class Game
    {
        public Game()
        {
            GameDate = DateTime.Now;
            Players = new List<Player>();
            Results = new HashSet<SetResult>();
        }

        public virtual Guid Id { get; set; }
        public virtual IList<Player> Players { get; set; }
        public virtual ISet<SetResult> Results { get; set; }
        public virtual DateTime GameDate { get; set; }
        public virtual Guid ClubId { get; set; }
    }
}
