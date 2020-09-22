﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Voting.Data.Models;

namespace Voting.Data.Migrations
{
    [DbContext(typeof(VotingContext))]
    partial class VotingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Voting.Data.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PrecinctId")
                        .HasColumnType("int");

                    b.Property<int>("VoterId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PrecinctId")
                        .IsUnique()
                        .HasFilter("([PrecinctId] IS NOT NULL)");

                    b.HasIndex("VoterId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Voting.Data.Models.BallotIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ElectionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsYea")
                        .HasColumnType("bit");

                    b.Property<int?>("VoteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ElectionId");

                    b.HasIndex("VoteId");

                    b.ToTable("BallotIssues");
                });

            modelBuilder.Entity("Voting.Data.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Ethnicity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("Voting.Data.Models.CandidateElection", b =>
                {
                    b.Property<int>("ElectionId")
                        .HasColumnType("int");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.HasKey("ElectionId", "CandidateId");

                    b.HasIndex("CandidateId");

                    b.ToTable("CandidateElections");
                });

            modelBuilder.Entity("Voting.Data.Models.CandidateOffice", b =>
                {
                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("CandidateId", "OfficeId");

                    b.HasIndex("OfficeId");

                    b.ToTable("CandidateOffices");
                });

            modelBuilder.Entity("Voting.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("CountyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasFilter("([AddressId] IS NOT NULL)");

                    b.HasIndex("CountyId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Voting.Data.Models.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasFilter("([AddressId] IS NOT NULL)");

                    b.HasIndex("StateId");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("Voting.Data.Models.Election", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("ElectionDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Elections");
                });

            modelBuilder.Entity("Voting.Data.Models.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficeHolderId")
                        .HasColumnType("int");

                    b.Property<int?>("OfficeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TermLimit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeHolderId");

                    b.HasIndex("OfficeTypeId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Voting.Data.Models.OfficeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OfficeTypes");
                });

            modelBuilder.Entity("Voting.Data.Models.Party", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PartyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("Voting.Data.Models.Precinct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Precincts");
                });

            modelBuilder.Entity("Voting.Data.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasFilter("([AddressId] IS NOT NULL)");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Voting.Data.Models.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("ElectionId")
                        .HasColumnType("int");

                    b.Property<int>("VoterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("ElectionId");

                    b.HasIndex("VoterId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Voting.Data.Models.Voter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DriversLicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ethnicity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartyId")
                        .HasColumnType("int");

                    b.Property<string>("VoterRegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("Voting.Data.Models.VoterElection", b =>
                {
                    b.Property<int>("ElectionId")
                        .HasColumnType("int");

                    b.Property<int>("VoterId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ElectionId", "VoterId");

                    b.HasIndex("VoterId");

                    b.ToTable("VoterElections");
                });

            modelBuilder.Entity("Voting.Data.Models.Address", b =>
                {
                    b.HasOne("Voting.Data.Models.Precinct", "Precinct")
                        .WithOne("Addresses")
                        .HasForeignKey("Voting.Data.Models.Address", "PrecinctId");

                    b.HasOne("Voting.Data.Models.Voter", "Voter")
                        .WithOne("Addresses")
                        .HasForeignKey("Voting.Data.Models.Address", "VoterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.BallotIssue", b =>
                {
                    b.HasOne("Voting.Data.Models.Election", "Election")
                        .WithMany("BallotIssues")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.Vote", "Vote")
                        .WithMany("BallotIssues")
                        .HasForeignKey("VoteId");
                });

            modelBuilder.Entity("Voting.Data.Models.Candidate", b =>
                {
                    b.HasOne("Voting.Data.Models.Party", "Party")
                        .WithMany("Candidates")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.CandidateElection", b =>
                {
                    b.HasOne("Voting.Data.Models.Candidate", "Candidate")
                        .WithMany("CandidateElections")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.Election", "Election")
                        .WithMany("CandidateElections")
                        .HasForeignKey("ElectionId")
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.CandidateOffice", b =>
                {
                    b.HasOne("Voting.Data.Models.Candidate", "Candidate")
                        .WithMany("CandidateOffices")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.Office", "Office")
                        .WithMany("CandidateOffices")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.City", b =>
                {
                    b.HasOne("Voting.Data.Models.Address", "Address")
                        .WithOne("Cities")
                        .HasForeignKey("Voting.Data.Models.City", "AddressId");

                    b.HasOne("Voting.Data.Models.County", "County")
                        .WithMany("Cities")
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.County", b =>
                {
                    b.HasOne("Voting.Data.Models.Address", "Address")
                        .WithOne("Counties")
                        .HasForeignKey("Voting.Data.Models.County", "AddressId");

                    b.HasOne("Voting.Data.Models.State", "State")
                        .WithMany("Counties")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.Election", b =>
                {
                    b.HasOne("Voting.Data.Models.Office", "Office")
                        .WithMany("Elections")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.Candidate", "Winner")
                        .WithMany("Elections")
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.Office", b =>
                {
                    b.HasOne("Voting.Data.Models.Candidate", "OfficeHolder")
                        .WithMany("Offices")
                        .HasForeignKey("OfficeHolderId")
                        .HasConstraintName("FK_Offices_Candidates_CandidateId");

                    b.HasOne("Voting.Data.Models.OfficeType", "OfficeType")
                        .WithMany("Offices")
                        .HasForeignKey("OfficeTypeId");
                });

            modelBuilder.Entity("Voting.Data.Models.State", b =>
                {
                    b.HasOne("Voting.Data.Models.Address", "Address")
                        .WithOne("States")
                        .HasForeignKey("Voting.Data.Models.State", "AddressId");
                });

            modelBuilder.Entity("Voting.Data.Models.Vote", b =>
                {
                    b.HasOne("Voting.Data.Models.Candidate", "Candidate")
                        .WithMany("Votes")
                        .HasForeignKey("CandidateId");

                    b.HasOne("Voting.Data.Models.Election", "Election")
                        .WithMany("Votes")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.Voter", "Voter")
                        .WithMany("Votes")
                        .HasForeignKey("VoterId")
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.Voter", b =>
                {
                    b.HasOne("Voting.Data.Models.Party", "Party")
                        .WithMany("Voters")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Voting.Data.Models.VoterElection", b =>
                {
                    b.HasOne("Voting.Data.Models.Election", "Election")
                        .WithMany("VoterElections")
                        .HasForeignKey("ElectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Voting.Data.Models.Voter", "Voter")
                        .WithMany("VoterElections")
                        .HasForeignKey("VoterId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
