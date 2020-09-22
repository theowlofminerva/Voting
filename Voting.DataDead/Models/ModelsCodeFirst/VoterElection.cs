using System;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class VoterElection
    {
        public int Id { get; set; }

        public Models.Election Election { get; set; }

        public int ElectionId { get; set; }

        public Models.Voter Voter { get; set; }

        public int VoterId { get; set; }
    }
}
