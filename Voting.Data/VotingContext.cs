using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Voting.Data.Models;

namespace Voting.Data
{
    public class VotingContext : DbContext
    {

        public VotingContext(DbContextOptions<VotingContext> options) : base(options)
        {
        }

        public DbSet<Voter> Voters { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<OfficeType> OfficeTypes { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<Precinct> Precincts { get; set; }
        public DbSet<BallotIssue> BallotIssues { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Office> Offices { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>()
                .HasMany(x => x.Counties)
                .WithOne(x => x.State)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<County>()
                .HasMany(x => x.Cities)
                .WithOne(x => x.County)
                .OnDelete(DeleteBehavior.Restrict);


        }


    }

}
