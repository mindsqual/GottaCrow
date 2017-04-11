using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using GottaCrowWebUI.Entities;

namespace GottaCrowWebUI.Migrations
{
    [DbContext(typeof(JobSearchActivityDbContext))]
    partial class JobSearchActivityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GottaCrowWebUI.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GottaCrowWebUI.Entities.JobSearchActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActivityType");

                    b.Property<int?>("ContactId");

                    b.Property<DateTime>("HappenedOn");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GottaCrowWebUI.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("FullName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GottaCrowWebUI.Entities.Contact", b =>
                {
                    b.HasOne("GottaCrowWebUI.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("GottaCrowWebUI.Entities.JobSearchActivity", b =>
                {
                    b.HasOne("GottaCrowWebUI.Entities.Contact")
                        .WithMany()
                        .HasForeignKey("ContactId");
                });
        }
    }
}
