using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class Club
    {
        public Club()
        {
            Players = new HashSet<Player>();
        }

        public virtual Guid Id { get; set; }
        public virtual string ClubName { get; set; }
        public virtual ISet<Player> Players { get; set; }
        public virtual string ClubSettings { get; set; }

    }

    public class ClubModel
    {
        public Guid Id { get; set; }
        public string ClubName { get; set; }
        public ClubSetting ClubSetting { get; set; }
    }

    public class ClubSetting
    {
        public int Sets { get; set; }
        public bool AllowTiedGame { get; set; }
    }
}
