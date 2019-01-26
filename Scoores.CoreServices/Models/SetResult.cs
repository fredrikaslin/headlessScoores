using System;
using System.Collections.Generic;
using System.Text;

namespace Scoores.CoreServices.Models
{
    public class SetResult
    {
        public virtual Guid Id { get; set; }
        public virtual Guid PlayerId { get; set; }
        public virtual int Score { get; set; }
        public virtual int PlusMinusPoints { get; set; }
        public virtual SetOutcome SetOutcome { get; set; }
        public virtual int SetNr { get; set; }
        public virtual Guid ClubId { get; set; }
        public virtual Game Game { get; set; }

    }
}
