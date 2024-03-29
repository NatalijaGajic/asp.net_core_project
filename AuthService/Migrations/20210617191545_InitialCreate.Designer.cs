﻿// <auto-generated />
using System;
using AuthService.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthService.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    [Migration("20210617191545_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthService.Entities.AuthInfo", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("UserId");

                    b.Property<string>("PrivateToken")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PrivateToken");

                    b.Property<string>("PublicToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PublicToken");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Role");

                    b.Property<DateTime>("TimeOfIssuingPublicToken")
                        .HasColumnType("datetime2")
                        .HasColumnName("TimeOfIssuingPublicToken");

                    b.HasKey("UserId");

                    b.ToTable("AuthInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
