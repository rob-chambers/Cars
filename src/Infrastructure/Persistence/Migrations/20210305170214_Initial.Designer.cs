﻿// <auto-generated />
using Cars.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cars.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210305170214_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cars.Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.HasKey("Id")
                        .IsClustered(false);

                    b.HasIndex(new[] { "Id" }, "PK_Category_Id")
                        .IsUnique()
                        .IsClustered();

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Cars.Core.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id")
                        .IsClustered(false);

                    b.HasIndex(new[] { "Id" }, "PK_Make_Id")
                        .IsUnique()
                        .IsClustered();

                    b.ToTable("Make");
                });

            modelBuilder.Entity("Cars.Core.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MakeId")
                        .HasColumnType("int");

                    b.Property<decimal>("MinPrice")
                        .HasColumnType("smallmoney");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("WarrantyId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .IsClustered(false);

                    b.HasIndex(new[] { "CategoryId" }, "IX_Model_Category_Id");

                    b.HasIndex(new[] { "MakeId" }, "IX_Model_Make_Id");

                    b.HasIndex(new[] { "WarrantyId" }, "IX_Model_Warranty_Id");

                    b.HasIndex(new[] { "Id" }, "PK_Model_Id")
                        .IsUnique()
                        .IsClustered();

                    b.ToTable("Model");
                });

            modelBuilder.Entity("Cars.Core.Entities.Warranty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Mileage")
                        .HasColumnType("smallint");

                    b.Property<byte>("Years")
                        .HasColumnType("tinyint");

                    b.HasKey("Id")
                        .IsClustered(false);

                    b.HasIndex(new[] { "Id" }, "PK_Warranty_Id")
                        .IsUnique()
                        .IsClustered();

                    b.ToTable("Warranty");
                });

            modelBuilder.Entity("Cars.Core.Entities.Model", b =>
                {
                    b.HasOne("Cars.Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Core.Entities.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cars.Core.Entities.Warranty", "Warranty")
                        .WithMany()
                        .HasForeignKey("WarrantyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Make");

                    b.Navigation("Warranty");
                });

            modelBuilder.Entity("Cars.Core.Entities.Make", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
