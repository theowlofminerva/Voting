using Microsoft.EntityFrameworkCore;

namespace Voting.Data.Models
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

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BallotIssue> BallotIssues { get; set; }
        public virtual DbSet<CandidateElection> CandidateElections { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<Election> Elections { get; set; }
        public virtual DbSet<OfficeType> OfficeTypes { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<Precinct> Precincts { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<VoterElection> VoterElections { get; set; }
        public virtual DbSet<CandidateOffice> CandidateOffices { get; set; }
        public virtual DbSet<Voter> Voters { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=Voting;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Office>()
            //    .HasOne(x => x.OfficeHolder)
            //    .WithMany(x => x.CurrentOfficeHeld)
            //    .HasForeignKey(p => p.OfficeHolderId);


            modelBuilder.Entity<CandidateOffice>()
                .HasKey(x => new {x.CandidateId, x.OfficeId});

            modelBuilder.Entity<CandidateElection>()
                .HasKey(x => new { x.ElectionId, x.CandidateId });

            modelBuilder.Entity<VoterElection>()
                .HasKey(x => new { x.ElectionId, x.VoterId });
            //entity.HasOne(d => d.Winner)
            //    .WithMany(p => p.Elections)
            //    .HasForeignKey(d => d.WinnerId)
            // 
            //entity.HasOne(d => d.Winner)
            //    .WithMany(p => p.Elections)
            //    .HasForeignKey(d => d.WinnerId)
            //    .OnDelete(DeleteBehavior.ClientSetNull);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
