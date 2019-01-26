using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class Match
    {
        public Match(Guid? gameId, List<SetResult> results)
        {
            GameId = gameId;
            Results = results;
        }

        public Guid? GameId { get; set; }
        public List<SetResult> Results { get; set; }
        public virtual MatchOutcome MatchOutcome
        {

            get
            {
                if (Results.Where(x => x.SetOutcome == SetOutcome.Win).Count() > Results.Where(x => x.SetOutcome == SetOutcome.Loss).Count())
                {
                    return MatchOutcome.Win;
                }
                if (Results.Where(x => x.SetOutcome == SetOutcome.Win).Count() == Results.Where(x => x.SetOutcome == SetOutcome.Loss).Count())
                {
                    return MatchOutcome.Tie;
                }
                else
                {
                    return MatchOutcome.Loss;
                }
            }
        }
    }

}
