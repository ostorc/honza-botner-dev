﻿// <auto-generated />
using System;
using HonzaBotner.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HonzaBotner.Migrations
{
    [DbContext(typeof(HonzaBotnerDbContext))]
    [Migration("20210211221437_EmojiCount")]
    partial class EmojiCount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("HonzaBotner.Database.CountedEmoji", b =>
                {
                    b.Property<decimal>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("FirstUsedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("Times")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("CountedEmojis");
                });

            modelBuilder.Entity("HonzaBotner.Database.Counter", b =>
                {
                    b.Property<decimal>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Count")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("UserId");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("HonzaBotner.Database.Verification", b =>
                {
                    b.Property<decimal>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("AuthId")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("AuthId")
                        .IsUnique();

                    b.ToTable("Verifications");
                });
#pragma warning restore 612, 618
        }
    }
}
