﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RocketGateway.DbContext;

#nullable disable

namespace RocketGateway.Migrations
{
    [DbContext(typeof(RocketsDbContext))]
    partial class RocketsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RocketGateway.DbContext.Models.Rocket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ExplodedReason")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LaunchSpeed")
                        .HasColumnType("integer");

                    b.Property<string>("Mission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WasExploded")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Rockets");
                });
#pragma warning restore 612, 618
        }
    }
}