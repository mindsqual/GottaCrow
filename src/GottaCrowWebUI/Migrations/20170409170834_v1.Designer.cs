using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using GottaCrowWebUI.Entities;

namespace GottaCrowWebUI.Migrations
{
    [DbContext(typeof(JobSearchActivityDbContext))]
    [Migration("20170409170834_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GottaCrowWebUI.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmailId");

                    b.Property<int?>("PersonId");

                    b.Property<int?>("PhoneId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GottaCrowWebUI.Entities.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullEmail");

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

            modelBuilder.Entity("GottaCrowWebUI.Entities.PhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullNumber");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("GottaCrowWebUI.Entities.Contact", b =>
                {
                    b.HasOne("GottaCrowWebUI.Entities.Email")
                        .WithMany()
                        .HasForeignKey("EmailId");

                    b.HasOne("GottaCrowWebUI.Entities.Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("GottaCrowWebUI.Entities.PhoneNumber")
                        .WithMany()
                        .HasForeignKey("PhoneId");
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
