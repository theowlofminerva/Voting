using System;

namespace Voting.Data.Models.ModelsCodeFirst
{
    [Serializable]
    public class CandidateElection
    {

        public Models.Candidate Candidate { get; set; }

        public int CandidateId { get; set; }

        public Election Election { get; set; }

        public int ElectionId { get; set; }
    }
}
