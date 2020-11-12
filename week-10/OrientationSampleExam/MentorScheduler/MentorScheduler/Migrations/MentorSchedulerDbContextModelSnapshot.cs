﻿// <auto-generated />
using MentorScheduler.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MentorScheduler.Migrations
{
    [DbContext(typeof(MentorSchedulerDbContext))]
    partial class MentorSchedulerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MentorScheduler.Models.Entities.Class", b =>
                {
                    b.Property<long>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("MentorScheduler.Models.Entities.Mentor", b =>
                {
                    b.Property<long>("MentorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("ClassId")
                        .HasColumnType("bigint");

                    b.Property<string>("MentorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MentorId");

                    b.HasIndex("ClassId");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("MentorScheduler.Models.Entities.Mentor", b =>
                {
                    b.HasOne("MentorScheduler.Models.Entities.Class", "Class")
                        .WithMany("Mentors")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("MentorScheduler.Models.Entities.Class", b =>
                {
                    b.Navigation("Mentors");
                });
#pragma warning restore 612, 618
        }
    }
}
