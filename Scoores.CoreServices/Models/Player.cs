using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class Player
    {
        public Player()
        {
            Games = new HashSet<Game>();
        }

        public virtual Guid Id { get; set; }
        public virtual string PlayerName { get; set; }
        public virtual int Elo { get; set; } = 1500;
        public virtual Club Club { get; set; }
        public virtual UserAccount UserAccount { get; set; }
        public virtual ISet<Game> Games { get; set; }
    }
}
