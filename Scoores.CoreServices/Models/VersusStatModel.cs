using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class VersusStatModel
    {
        public virtual string Player { get; set; }
        public virtual string Opponent { get; set; }
        public virtual int PlayerNumberOfWins { get; set; }
        public virtual int OpponentNumberOfWins { get; set; }

    }
}
