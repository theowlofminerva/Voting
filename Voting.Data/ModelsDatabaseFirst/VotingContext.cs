using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Voting.Data.ModelsDatabaseFirst
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

        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<BallotIssues> BallotIssues { get; set; }
        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Counties> Counties { get; set; }
        public virtual DbSet<Elections> Elections { get; set; }
        public virtual DbSet<OfficeTypes> OfficeTypes { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Parties> Parties { get; set; }
        public virtual DbSet<Precincts> Precincts { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Voters> Voters { get; set; }
        public virtual DbSet<Votes> Votes { get; set; }

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
            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasIndex(e => e.PrecinctId)
                    .IsUnique()
                    .HasFilter("([PrecinctId] IS NOT NULL)");

                entity.HasIndex(e => e.VoterId)
                    .IsUnique();

                entity.Property(e => e.Address1).IsRequired();

                entity.Property(e => e.ZipCode).IsRequired();

                entity.HasOne(d => d.Precinct)
                    .WithOne(p => p.Addresses)
                    .HasForeignKey<Addresses>(d => d.PrecinctId);

                entity.HasOne(d => d.Voter)
                    .WithOne(p => p.Addresses)
                    .HasForeignKey<Addresses>(d => d.VoterId);
            });

            modelBuilder.Entity<BallotIssues>(entity =>
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

            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.OfficeId)
                    .IsUnique()
                    .HasFilter("([OfficeId] IS NOT NULL)");

                entity.HasIndex(e => e.PartyId);

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.ElectionId);

                entity.HasOne(d => d.Office)
                    .WithOne(p => p.Candidates)
                    .HasForeignKey<Candidates>(d => d.OfficeId);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.PartyId);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .IsUnique()
                    .HasFilter("([AddressId] IS NOT NULL)");

                entity.HasIndex(e => e.CountyId);

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.Cities)
                    .HasForeignKey<Cities>(d => d.AddressId);

                entity.HasOne(d => d.County)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateId);
            });

            modelBuilder.Entity<Counties>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .IsUnique()
                    .HasFilter("([AddressId] IS NOT NULL)");

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.Counties)
                    .HasForeignKey<Counties>(d => d.AddressId);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Counties)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OfficeTypes>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Offices>(entity =>
            {
                entity.HasIndex(e => e.OfficeTypeId)
                    .IsUnique()
                    .HasFilter("([OfficeTypeId] IS NOT NULL)");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.OfficeType)
                    .WithOne(p => p.Offices)
                    .HasForeignKey<Offices>(d => d.OfficeTypeId);
            });

            modelBuilder.Entity<Parties>(entity =>
            {
                entity.Property(e => e.PartyName).IsRequired();
            });

            modelBuilder.Entity<Precincts>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.HasIndex(e => e.AddressId)
                    .IsUnique()
                    .HasFilter("([AddressId] IS NOT NULL)");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Address)
                    .WithOne(p => p.States)
                    .HasForeignKey<States>(d => d.AddressId);
            });

            modelBuilder.Entity<Voters>(entity =>
            {
                entity.HasIndex(e => e.ElectionId);

                entity.HasIndex(e => e.PartyId);

                entity.Property(e => e.DriversLicenseNumber).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.VoterRegistrationNumber).IsRequired();

                entity.HasOne(d => d.Election)
                    .WithMany(p => p.Voters)
                    .HasForeignKey(d => d.ElectionId);

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.Voters)
                    .HasForeignKey(d => d.PartyId);
            });

            modelBuilder.Entity<Votes>(entity =>
            {
                entity.HasIndex(e => e.CandidateId);

                entity.HasIndex(e => e.VoterId)
                    .IsUnique();

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.Votes)
                    .HasForeignKey(d => d.CandidateId);

                entity.HasOne(d => d.Voter)
                    .WithOne(p => p.Votes)
                    .HasForeignKey<Votes>(d => d.VoterId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
