﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pop_Mihai_Lab.Data;

namespace Pop_Mihai_Lab.Migrations
{
    [DbContext(typeof(Pop_Mihai_LabContext))]
    partial class Pop_Mihai_LabContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pop_Mihai_Lab.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Pop_Mihai_Lab.Models.Comanda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("NrProduse")
                        .HasColumnType("int");

                    b.Property<int>("ProdusID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ProdusID");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("Pop_Mihai_Lab.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culoare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Pret")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("Pop_Mihai_Lab.Models.Comanda", b =>
                {
                    b.HasOne("Pop_Mihai_Lab.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pop_Mihai_Lab.Models.Produs", "Produs")
                        .WithMany()
                        .HasForeignKey("ProdusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
