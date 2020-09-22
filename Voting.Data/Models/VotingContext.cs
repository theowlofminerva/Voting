using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<CandidateOffice> CandidateOffices { get; set; }
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
        public virtual DbSet<Voter> Voters { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Voting;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.PrecinctId)
                    .IsUnique()
                    .HasFilter("([PrecinctId] IS NOT NULL)");

                entity.HasIndex(e => e.VoterId)
                    .IsUnique();

                entity.Property(e => e.Address1).IsRequired();

                entity.Property(e => e.Address2).IsRequired();

                entity.Property(e => e.ZipCode).IsRequired();

                entity.HasOne(d => d.Precinct)
                    .WithOne(p => p.Addresses)
                    .HasForeignKey<Address>(d => d.PrecinctId);

                entity.HasOne(d => d.Voter)
                    .WithOne(p => p.Addresses)
                    .HasForeignKey<Address>(d => d.VoterId);
            });

            modelBuilder.Entity<BallotIssue>(entity =>
            {
                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.VoteId);

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.BallotIssues)
                    .HasForeignKey(d => d.ElectionId);

                entity.HasOne(d => d.Vote)
                    .WithMany(p => p.BallotIssues)
                    .HasForeignKey(d => d.VoteId);
            });

            modelBuilder.Entity<CandidateElection>(entity =>
            {
                entity.HasKey(e => new { e.ElectionId, e.CandidateId });

                entity.HasIndex(e => e.CandidateId);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateElections)
                    .HasForeignKey(d => d.CandidateId);

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.CandidateElections)
                    .HasForeignKey(d => d.ElectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CandidateOffice>(entity =>
            {
                entity.HasKey(e => new { e.CandidateId, e.OfficeId });

                entity.HasIndex(e => e.OfficeId);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateOffices)
                    .HasForeignKey(d => d.CandidateId);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.CandidateOffices)
                    .HasForeignKey(d => d.OfficeId);
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.HasIndex(e => e.PartyId);

                entity.Property(e => e.Ethnicity).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.Gender).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.PartyId);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .IsUnique()
                    .HasFilter("([AddressId] IS NOT NULL)");

                entity.HasIndex(e => e.CountyId);

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.Cities)
                    .HasForeignKey<City>(d => d.AddressId);

                entity.HasOne(d => d.County)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountyId);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .IsUnique()
                    .HasFilter("([AddressId] IS NOT NULL)");

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.Counties)
                    .HasForeignKey<County>(d => d.AddressId);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Counties)
                    .HasForeignKey(d => d.StateId);
            });

            modelBuilder.Entity<Election>(entity =>
            {
                entity.HasIndex(e => e.OfficeId);

                entity.HasIndex(e => e.WinnerId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Elections)
                    .HasForeignKey(d => d.OfficeId);

                entity.HasOne(d => d.Winner)
                    .WithMany(p => p.Elections)
                    .HasForeignKey(d => d.WinnerId);
            });

            modelBuilder.Entity<OfficeType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.HasIndex(e => e.OfficeTypeId);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TermLimit).IsRequired();

                entity.HasOne(d => d.OfficeHolder)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.OfficeHolderId)
                    .HasConstraintName("FK_Offices_Candidates_CandidateId");

                entity.HasOne(d => d.OfficeType)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.OfficeTypeId);
            });

            modelBuilder.Entity<Party>(entity =>
            {
                entity.Property(e => e.PartyName).IsRequired();
            });

            modelBuilder.Entity<Precinct>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .IsUnique()
                    .HasFilter("([AddressId] IS NOT NULL)");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.States)
                    .HasForeignKey<State>(d => d.AddressId);
            });

            modelBuilder.Entity<VoterElection>(entity =>
            {
                entity.HasKey(e => new { e.ElectionId, e.VoterId });

                entity.HasIndex(e => e.VoterId);

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.VoterElections)
                    .HasForeignKey(d => d.ElectionId);

                entity.HasOne(d => d.Voter)
                    .WithMany(p => p.VoterElections)
                    .HasForeignKey(d => d.VoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Voter>(entity =>
            {
                entity.HasIndex(e => e.PartyId);

                entity.Property(e => e.DriversLicenseNumber).IsRequired();

                entity.Property(e => e.Ethnicity).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.Gender).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.VoterRegistrationNumber).IsRequired();

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.Voters)
                    .HasForeignKey(d => d.PartyId);
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.HasIndex(e => e.CandidateId);

                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.VoterId);

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.CandidateId);

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.ElectionId);

                entity.HasOne(d => d.Voter)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.VoterId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
