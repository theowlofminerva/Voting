using Microsoft.EntityFrameworkCore;

namespace Voting.Data.Models.ModelsCodeFirst
{
    public partial class VotingContext : DbContext
    {
        public VotingContext()
        {
        }

        public VotingContext(DbContextOptions<VotingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Address> Addresses { get; set; }
        public virtual DbSet<Models.BallotIssue> BallotIssues { get; set; }
        public virtual DbSet<Models.Candidate> Candidates { get; set; }
        public virtual DbSet<Models.City> Cities { get; set; }
        public virtual DbSet<Models.County> Counties { get; set; }
        public virtual DbSet<Models.Election> Elections { get; set; }
        public virtual DbSet<Models.OfficeType> OfficeTypes { get; set; }
        public virtual DbSet<Models.Office> Offices { get; set; }
        public virtual DbSet<Models.Party> Parties { get; set; }
        public virtual DbSet<Models.Precinct> Precincts { get; set; }
        public virtual DbSet<Models.State> States { get; set; }
        public virtual DbSet<Models.Voter> Voters { get; set; }
        public virtual DbSet<Models.Vote> Votes { get; set; }
        public virtual DbSet<Models.CandidateElection> CandidateElections { get; set; }

        public virtual DbSet<Models.VoterElection> VoterElections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.CandidateElection>().HasKey(sc => new { sc.CandidateId, sc.ElectionId });

            modelBuilder.Entity<Models.VoterElection>().HasKey(sc => new { sc.ElectionId, sc.VoterId });

            //modelBuilder.Entity<Models.Election>()
            //    .HasOne(x => x.Winner)
            //    .WithMany(x => x.ElectionsWon)
            //    .HasForeignKey(x => x.WinnerId);
        }

    }
}
