using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectManagement.API.Models;

namespace StudentApplication.API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170709182245_ProjectManagement.API.Models.ApplicationContext")]
    partial class ProjectManagementAPIModelsApplicationContext
    {
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManagement.API.Models.Project", b =>
                {
                    b.Property<long>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjectCode");

                    b.Property<string>("ProjectName");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("StartDate");

                    b.Property<DateTime?>("EndDate");

                    b.Property<string>("Status");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");
                });
        }
    }
}
