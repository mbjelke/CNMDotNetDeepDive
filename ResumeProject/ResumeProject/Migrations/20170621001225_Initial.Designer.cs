using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ResumeProject.Models;

namespace ResumeProject.Migrations
{
    [DbContext(typeof(ResumeProjectContext))]
    [Migration("20170621001225_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResumeProject.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1")
                        .IsRequired();

                    b.Property<string>("Address2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Facebook");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("LinkedIn");

                    b.Property<string>("MiddleInit")
                        .HasMaxLength(1);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("State")
                        .HasMaxLength(2);

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.Property<string>("Zip");

                    b.HasKey("ID");

                    b.ToTable("Person");
                });
        }
    }
}
