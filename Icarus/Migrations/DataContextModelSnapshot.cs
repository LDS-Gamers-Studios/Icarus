﻿// <auto-generated />
using System;
using Icarus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Icarus.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Icarus.Models.Filter", b =>
                {
                    b.Property<int>("FilterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FilterText")
                        .HasColumnType("longtext");

                    b.Property<string>("FilterTextConverted")
                        .HasColumnType("longtext");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("FilterId");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("Icarus.Models.FilterException", b =>
                {
                    b.Property<int>("FilterExceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ExceptionText")
                        .HasColumnType("longtext");

                    b.Property<int?>("FilterId")
                        .HasColumnType("int");

                    b.HasKey("FilterExceptionId");

                    b.HasIndex("FilterId");

                    b.ToTable("FilterException");
                });

            modelBuilder.Entity("Icarus.Models.Flag", b =>
                {
                    b.Property<int>("FlagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<ulong>("FlaggedById")
                        .HasColumnType("bigint unsigned");

                    b.Property<int>("ResolutionPoints")
                        .HasColumnType("int");

                    b.Property<DateTime>("ResolutionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ResolutionType")
                        .HasColumnType("int");

                    b.Property<ulong>("ResolvedById")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("SourcContent")
                        .HasColumnType("longtext");

                    b.Property<ulong>("SourceChannelId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("SourceMatches")
                        .HasColumnType("longtext");

                    b.Property<ulong>("SourceMessageId")
                        .HasColumnType("bigint unsigned");

                    b.Property<ulong>("SourceUserId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("SystemMessage")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("FlagId");

                    b.ToTable("Flag");
                });

            modelBuilder.Entity("Icarus.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<ulong>("DiscordId")
                        .HasColumnType("bigint unsigned");

                    b.Property<string>("GuildedId")
                        .HasColumnType("longtext");

                    b.HasKey("MemberId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("Icarus.Models.ServerSettingValue", b =>
                {
                    b.Property<int>("ServerSettingValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("ServerSettingValueId");

                    b.ToTable("ServerSettingValue");
                });

            modelBuilder.Entity("Icarus.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AttachmentURL")
                        .HasColumnType("longtext");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsEmbed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Icarus.Models.FilterException", b =>
                {
                    b.HasOne("Icarus.Models.Filter", "Filter")
                        .WithMany("FilterExceptions")
                        .HasForeignKey("FilterId");

                    b.Navigation("Filter");
                });

            modelBuilder.Entity("Icarus.Models.Filter", b =>
                {
                    b.Navigation("FilterExceptions");
                });
#pragma warning restore 612, 618
        }
    }
}
