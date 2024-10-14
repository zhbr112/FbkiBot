﻿// <auto-generated />
using System;
using FbkiBot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FbkiBot.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20241014091314_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FbkiBot.Models.SavedMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AddedAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("AddedById")
                        .HasColumnType("bigint");

                    b.Property<string>("AddedByName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddedByUsername")
                        .HasColumnType("text");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<int>("MessageId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SavedMessages");
                });

            modelBuilder.Entity("FbkiBot.Models.UserMount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("UserMounts");
                });
#pragma warning restore 612, 618
        }
    }
}
