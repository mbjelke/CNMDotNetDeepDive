using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Phones.Models;

namespace Phones.Migrations
{
    [DbContext(typeof(PhonesContext))]
    partial class PhonesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Phones.Models.Phone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CameraPix");

                    b.Property<string>("Color")
                        .HasMaxLength(20);

                    b.Property<string>("Condition")
                        .HasMaxLength(20);

                    b.Property<string>("Mfg")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("OS")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("Release");

                    b.Property<string>("Size")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Phone");
                });
        }
    }
}
