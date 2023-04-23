﻿// <auto-generated />
using System;
using BlazorCompanyEventsApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCompanyEventsApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorCompanyEventsApp.Shared.Models.CompanyEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyEvents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAndTime = new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Annual party held for the entire company",
                            Name = "Annual Party"
                        },
                        new
                        {
                            Id = 2,
                            DateAndTime = new DateTime(2023, 4, 23, 11, 51, 34, 94, DateTimeKind.Utc).AddTicks(8040),
                            Description = "Introduction course to React for beginners",
                            Name = "Intro course to React.js"
                        },
                        new
                        {
                            Id = 3,
                            DateAndTime = new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "SQL learning module",
                            Name = "Learning in databases"
                        });
                });

            modelBuilder.Entity("BlazorCompanyEventsApp.Shared.Models.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CompanyEventId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyEventId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("BlazorCompanyEventsApp.Shared.Models.Participant", b =>
                {
                    b.HasOne("BlazorCompanyEventsApp.Shared.Models.CompanyEvent", null)
                        .WithMany("Participants")
                        .HasForeignKey("CompanyEventId");
                });

            modelBuilder.Entity("BlazorCompanyEventsApp.Shared.Models.CompanyEvent", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
