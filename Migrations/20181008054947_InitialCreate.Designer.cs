﻿// <auto-generated />
using CodingClubTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodingClubTest.Migrations
{
    [DbContext(typeof(CodingClubDbContext))]
    [Migration("20181008054947_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("CodingClubTest.Models.Member", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.HasKey("ID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
