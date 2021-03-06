// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Side.Website.Context;

namespace Side.Website.Migrations
{
    [DbContext(typeof(WebsiteDBContext))]
    [Migration("20220609204705_01-tables")]
    partial class _01tables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Side.Website.Models.Jury", b =>
                {
                    b.Property<int>("JuryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JuryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JuryPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JurySurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JuryID");

                    b.ToTable("Juries");
                });

            modelBuilder.Entity("Side.Website.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreationVideoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("GraduateStatus")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("GraduateYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolID")
                        .HasColumnType("int");

                    b.Property<int>("SchooldID")
                        .HasColumnType("int");

                    b.Property<string>("ShowRealVideoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.HasIndex("SchoolID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Side.Website.Models.School", b =>
                {
                    b.Property<int>("SchooldID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SchoolLogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchooldID");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("Side.Website.Models.Person", b =>
                {
                    b.HasOne("Side.Website.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolID");

                    b.Navigation("School");
                });
#pragma warning restore 612, 618
        }
    }
}
