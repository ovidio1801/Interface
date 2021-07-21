﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RRHH.Data;

namespace RRHH.Migrations
{
    [DbContext(typeof(RRHHContext))]
    partial class RRHHContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RRHH.Models.Parametro", b =>
                {
                    b.Property<int>("ID_PARAM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CENTRO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CODIGO_TR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUENTA_CR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CUENTA_DB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DESCRIPCION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_PARAM");

                    b.ToTable("PS_CA_PARAM");
                });

            modelBuilder.Entity("RRHH.Models.TiposCheque", b =>
                {
                    b.Property<int>("ID_TIPO_CHEQUE")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("COD_TIPO_CHEQUE")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("DESCRIPCION")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_TIPO_CHEQUE");

                    b.ToTable("PS_CA_TIPO_CHEQUE");
                });
#pragma warning restore 612, 618
        }
    }
}