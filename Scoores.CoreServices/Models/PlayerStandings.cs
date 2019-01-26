using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class PlayerStandings
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfLosses { get; set; }
        public int? NumberOfTies { get; set; }
        public int PlusMinus { get; set; }
        public int WinPercent { get; set; }
        public int EloRanking { get; set; }
        public bool ValidNrOfGames { get; set; }
    }
}
