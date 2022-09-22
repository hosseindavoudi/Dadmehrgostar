﻿// <auto-generated />
using System;
using File.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace File.EfCore.Migrations
{
    [DbContext(typeof(FileContext))]
    [Migration("20220920203259_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("File.Domain.Board.Board", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BoardChairman")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BoardType_Id")
                        .HasColumnType("int");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DisputeResolutionPetitionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpertReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("File_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BoardType_Id");

                    b.HasIndex("File_Id");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("File.Domain.BoardType.BoardType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BoardTypes");
                });

            modelBuilder.Entity("File.Domain.File.File", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ArchiveNo")
                        .HasColumnType("bigint");

                    b.Property<int>("Client")
                        .HasColumnType("int");

                    b.Property<DateTime>("ClientVisitDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HasMandate")
                        .HasColumnType("int");

                    b.Property<string>("ProceederReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Reqester")
                        .HasColumnType("bigint");

                    b.Property<long>("Summoned")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("File.Domain.PenaltyTitle.PenaltyTitle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaidAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Petition_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("RemainingAmount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Petition_Id");

                    b.ToTable("PenaltyTitles");
                });

            modelBuilder.Entity("File.Domain.Petition.Petition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BoardType_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("File_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("NotificationPetitionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PetitionIssuanceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TotalPenalty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalPenaltyTitles")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoardType_Id");

                    b.HasIndex("File_Id");

                    b.ToTable("Petitions");
                });

            modelBuilder.Entity("File.Domain.ProceedingSession.ProceedingSession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Board_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Board_Id");

                    b.ToTable("ProceedingSessions");
                });

            modelBuilder.Entity("File.Domain.WorkHistory.WorkHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Petition_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkingHoursPerDay")
                        .HasColumnType("int");

                    b.Property<int>("WorkingHoursPerWeek")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Petition_Id");

                    b.ToTable("WorkHistories");
                });

            modelBuilder.Entity("File.Domain.Board.Board", b =>
                {
                    b.HasOne("File.Domain.BoardType.BoardType", "BoardType")
                        .WithMany("BoardsList")
                        .HasForeignKey("BoardType_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("File.Domain.File.File", "File")
                        .WithMany("BoardsList")
                        .HasForeignKey("File_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardType");

                    b.Navigation("File");
                });

            modelBuilder.Entity("File.Domain.PenaltyTitle.PenaltyTitle", b =>
                {
                    b.HasOne("File.Domain.Petition.Petition", "Petition")
                        .WithMany("PenaltyTitlesList")
                        .HasForeignKey("Petition_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Petition");
                });

            modelBuilder.Entity("File.Domain.Petition.Petition", b =>
                {
                    b.HasOne("File.Domain.BoardType.BoardType", "BoardType")
                        .WithMany("PetitionsList")
                        .HasForeignKey("BoardType_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("File.Domain.File.File", "File")
                        .WithMany("PetitionsList")
                        .HasForeignKey("File_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardType");

                    b.Navigation("File");
                });

            modelBuilder.Entity("File.Domain.ProceedingSession.ProceedingSession", b =>
                {
                    b.HasOne("File.Domain.Board.Board", "Board")
                        .WithMany("ProceedingSessionsList")
                        .HasForeignKey("Board_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Board");
                });

            modelBuilder.Entity("File.Domain.WorkHistory.WorkHistory", b =>
                {
                    b.HasOne("File.Domain.Petition.Petition", "Petition")
                        .WithMany("WorkHistoriesList")
                        .HasForeignKey("Petition_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Petition");
                });

            modelBuilder.Entity("File.Domain.Board.Board", b =>
                {
                    b.Navigation("ProceedingSessionsList");
                });

            modelBuilder.Entity("File.Domain.BoardType.BoardType", b =>
                {
                    b.Navigation("BoardsList");

                    b.Navigation("PetitionsList");
                });

            modelBuilder.Entity("File.Domain.File.File", b =>
                {
                    b.Navigation("BoardsList");

                    b.Navigation("PetitionsList");
                });

            modelBuilder.Entity("File.Domain.Petition.Petition", b =>
                {
                    b.Navigation("PenaltyTitlesList");

                    b.Navigation("WorkHistoriesList");
                });
#pragma warning restore 612, 618
        }
    }
}