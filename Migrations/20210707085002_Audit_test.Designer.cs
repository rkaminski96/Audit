// <auto-generated />
using System;
using AuditIssue.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuditIssue.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210707085002_Audit_test")]
    partial class Audit_test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuditIssue.Entities.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("AuditIssue.Entities.ReservationRequest", b =>
                {
                    b.HasBaseType("AuditIssue.Entities.Request");

                    b.Property<string>("ReservationComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationTo")
                        .HasColumnType("datetime2");

                    b.ToTable("ReservationRequests");
                });

            modelBuilder.Entity("AuditIssue.Entities.ReservationRequest", b =>
                {
                    b.HasOne("AuditIssue.Entities.Request", null)
                        .WithOne()
                        .HasForeignKey("AuditIssue.Entities.ReservationRequest", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
