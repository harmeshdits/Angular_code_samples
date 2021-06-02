﻿// <auto-generated />
using System;
using DitsPortal.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DitsPortal.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200327084831_AddTablesMigration")]
    partial class AddTablesMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.AnnualHolidays", b =>
                {
                    b.Property<int>("AnnualHolidayId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CalenderHolidays")
                        .HasColumnType("int");

                    b.Property<int>("MonthlyHolidays")
                        .HasColumnType("int");

                    b.HasKey("AnnualHolidayId");

                    b.ToTable("AnnualHoliday");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.ErrorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Application");

                    b.Property<string>("Callsite");

                    b.Property<string>("Exception");

                    b.Property<string>("Level");

                    b.Property<string>("Logged");

                    b.Property<string>("Logger");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("ErrorLog");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.GlobalCodeCategories", b =>
                {
                    b.Property<int>("GlobalCodeCategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("GlobalCodeCategoryId");

                    b.ToTable("GlobalCodeCategories");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.Leaves", b =>
                {
                    b.Property<int>("LeaveId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AppliedDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("FromSession")
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<double>("NumberOfDays")
                        .HasColumnType("Double");

                    b.Property<int>("PendingLeaves")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RejectedBy")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("RejectionDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("RejectionReason")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("ToSession")
                        .HasColumnType("varchar(255)");

                    b.HasKey("LeaveId");

                    b.ToTable("Leave");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.LeavesBalance", b =>
                {
                    b.Property<int>("LeaveBalanceId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Availed")
                        .HasColumnType("Double");

                    b.Property<double>("Balance")
                        .HasColumnType("Double");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("LeaveBalanceId");

                    b.ToTable("LeavesBalance");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.Permissions", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("PermissionName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.RolePermissions", b =>
                {
                    b.Property<int>("RolePermissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<int>("PermissionId");

                    b.Property<int>("RoleId");

                    b.Property<int>("ScreenId");

                    b.HasKey("RolePermissionId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("RoleName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.Screens", b =>
                {
                    b.Property<int>("ScreensId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("ScreensName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("ScreensId");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Base.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<int>("RoleId");

                    b.Property<int>("Userld");

                    b.HasKey("UserRoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.EmployeeHistories", b =>
                {
                    b.Property<int>("EmploymentHistoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Experience")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("From")
                        .HasColumnType("Datetime");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("To")
                        .HasColumnType("Datetime");

                    b.Property<int>("UserId");

                    b.HasKey("EmploymentHistoryId");

                    b.ToTable("EmployeeHistories");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.GlobalCodes", b =>
                {
                    b.Property<int>("GlobalCodeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodeName")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("GlobalCodeCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.HasKey("GlobalCodeId");

                    b.ToTable("GlobalCodes");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Projects", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("ProjectName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Rating")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("UserId");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Qualifications", b =>
                {
                    b.Property<int>("QualificationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<DateTime>("PassingYear")
                        .HasColumnType("Datetime");

                    b.Property<decimal>("Percentage")
                        .HasColumnType("decimal(16,3)");

                    b.Property<string>("UniversitySchool")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserID");

                    b.HasKey("QualificationId");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.DBEntities.Skills", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("Rating")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("SkillName")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserId");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("DitsPortal.DataAccess.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AlternateNumber");

                    b.Property<int?>("BloodGroup");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("Datetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("Datetime");

                    b.Property<DateTime?>("DateOfJoining");

                    b.Property<DateTime?>("DateOfLeaving");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("Datetime");

                    b.Property<int?>("Designation")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive");

                    b.Property<string>("IsApproved")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastLoggedIn");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("MediaId");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("Datetime");

                    b.Property<string>("OfficialEmail");

                    b.Property<string>("PAN");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone");

                    b.Property<string>("ResetToken");

                    b.Property<DateTime?>("ResetTokenExpired");

                    b.Property<string>("Skype");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
