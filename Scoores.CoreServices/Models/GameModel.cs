using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class GameModel
    {
        public virtual Dictionary<Guid, Score[]> PlayersScores { get; set; }
        public virtual string Player1Name { get; set; }
        public virtual string Player2Name { get; set; }
        public virtual bool AllowTiedGame { get; set; }
    }

    public class Score
    {
        public int SetNr { get; set; }
        public int? Result { get; set; }
    }
}
