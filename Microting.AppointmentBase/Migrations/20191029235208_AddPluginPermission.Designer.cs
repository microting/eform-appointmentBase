﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microting.AppointmentBase.Infrastructure.Data;

namespace Microting.AppointmentBase.Migrations
{
    [DbContext(typeof(AppointmentPnDbContext))]
    [Migration("20191029235208_AddPluginPermission")]
    partial class AddPluginPermission
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<string>("ColorHex");

                    b.Property<short?>("ColorRule");

                    b.Property<short?>("Completed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("Duration");

                    b.Property<string>("ExceptionString");

                    b.Property<DateTime?>("ExpireAt");

                    b.Property<string>("GlobalId");

                    b.Property<string>("Info");

                    b.Property<string>("MicrotingUuid")
                        .HasMaxLength(255);

                    b.Property<int?>("NextId");

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<int?>("RepeatEvery");

                    b.Property<int?>("RepeatType");

                    b.Property<DateTime?>("RepeatUntil");

                    b.Property<string>("Replacements");

                    b.Property<string>("Response");

                    b.Property<int?>("SdkeFormId");

                    b.Property<DateTime?>("StartAt");

                    b.Property<string>("Subject")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("NextId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentPrefillFieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentFvId");

                    b.Property<int?>("AppointmentId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("FieldId");

                    b.Property<string>("FieldValue");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("AppointmentPrefillFieldValues");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentPrefillFieldValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentFvId");

                    b.Property<int?>("AppointmentId");

                    b.Property<int>("AppointmentPrefillFieldValueId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("FieldId");

                    b.Property<string>("FieldValue");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AppointmentPrefillFieldValueVersions");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentSite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId");

                    b.Property<short?>("Completed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("ExceptionString");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<string>("SdkCaseId")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.ToTable("AppointmentSites");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentSiteVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId");

                    b.Property<int?>("AppointmentSiteId");

                    b.Property<short?>("Completed");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("ExceptionString");

                    b.Property<int>("MicrotingSiteUid");

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<string>("SdkCaseId")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AppointmentSiteVersions");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId");

                    b.Property<string>("Body");

                    b.Property<string>("ColorHex");

                    b.Property<short?>("ColorRule");

                    b.Property<short?>("Completed");

                    b.Property<short?>("Connected");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<int?>("Duration");

                    b.Property<string>("ExceptionString");

                    b.Property<DateTime?>("ExpireAt");

                    b.Property<string>("GlobalId");

                    b.Property<string>("Info");

                    b.Property<string>("Location")
                        .HasMaxLength(255);

                    b.Property<string>("MicrotingUid")
                        .HasMaxLength(255);

                    b.Property<int?>("NextId");

                    b.Property<string>("ProcessingState")
                        .HasMaxLength(255);

                    b.Property<int?>("RepeatEvery");

                    b.Property<int?>("RepeatType");

                    b.Property<DateTime?>("RepeatUntil");

                    b.Property<string>("Replacements");

                    b.Property<string>("Response");

                    b.Property<int?>("SdkeFormId");

                    b.Property<string>("SiteIds");

                    b.Property<DateTime?>("StartAt");

                    b.Property<string>("Subject")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("AppointmentVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValues");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValueVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("PermissionId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.ToTable("PluginGroupPermissions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermissionVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int?>("FK_PluginGroupPermissionVersions_PluginGroupPermissionId");

                    b.Property<int>("GroupId");

                    b.Property<bool>("IsEnabled");

                    b.Property<int>("PermissionId");

                    b.Property<int>("PluginGroupPermissionId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("FK_PluginGroupPermissionVersions_PluginGroupPermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("PluginGroupPermissionVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimName");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("PermissionName");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginPermissions");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", b =>
                {
                    b.HasOne("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", "Next")
                        .WithMany()
                        .HasForeignKey("NextId");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentPrefillFieldValue", b =>
                {
                    b.HasOne("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentPrefillFieldValues")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("Microting.AppointmentBase.Infrastructure.Data.Entities.AppointmentSite", b =>
                {
                    b.HasOne("Microting.AppointmentBase.Infrastructure.Data.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentSites")
                        .HasForeignKey("AppointmentId");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", b =>
                {
                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermissionVersion", b =>
                {
                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", "PluginGroupPermission")
                        .WithMany()
                        .HasForeignKey("FK_PluginGroupPermissionVersions_PluginGroupPermissionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
