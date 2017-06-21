using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Phones.Models;

namespace Phones.Migrations
{
    [DbContext(typeof(PhonesContext))]
    [Migration("20170524005208_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Phones.Models.Phone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Condition");

                    b.Property<string>("Mfg");

                    b.Property<string>("Model");

                    b.Property<string>("OS");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("Release");

                    b.Property<string>("Size");

                    b.HasKey("ID");

                    b.ToTable("Phone");
                });
        }
    }
}
