using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
{
    public partial class CompanyManagementContext : DbContext
    {
        public CompanyManagementContext()
        {
        }

        public CompanyManagementContext(DbContextOptions<CompanyManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepLocation> TblDepLocations { get; set; }
        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblDependent> TblDependents { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblLocation> TblLocations { get; set; }
        public virtual DbSet<TblProject> TblProjects { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblWorksOn> TblWorksOns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=123456;database= CompanyManagement;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepLocation>(entity =>
            {
                entity.HasKey(e => new { e.DepNum, e.LocNum });

                entity.ToTable("tblDepLocation");

                entity.Property(e => e.DepNum).HasColumnName("depNum");

                entity.Property(e => e.LocNum).HasColumnName("locNum");

                entity.HasOne(d => d.DepNumNavigation)
                    .WithMany(p => p.TblDepLocations)
                    .HasForeignKey(d => d.DepNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDepLocation_tblDepartment");

                entity.HasOne(d => d.LocNumNavigation)
                    .WithMany(p => p.TblDepLocations)
                    .HasForeignKey(d => d.LocNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDepLocation_tblLocation");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DepNum);

                entity.ToTable("tblDepartment");

                entity.Property(e => e.DepNum)
                    .ValueGeneratedNever()
                    .HasColumnName("depNum");

                entity.Property(e => e.DepName)
                    .HasMaxLength(50)
                    .HasColumnName("depName");

                entity.Property(e => e.MgrAssDate)
                    .HasColumnType("datetime")
                    .HasColumnName("mgrAssDate");

                entity.Property(e => e.MgrSsn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("mgrSSN");

                entity.HasOne(d => d.MgrSsnNavigation)
                    .WithMany(p => p.TblDepartments)
                    .HasForeignKey(d => d.MgrSsn)
                    .HasConstraintName("FK_tblDepartment_tblEmployee");
            });

            modelBuilder.Entity<TblDependent>(entity =>
            {
                entity.HasKey(e => new { e.DepName, e.EmpSsn });

                entity.ToTable("tblDependent");

                entity.Property(e => e.DepName)
                    .HasMaxLength(50)
                    .HasColumnName("depName");

                entity.Property(e => e.EmpSsn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("empSSN");

                entity.Property(e => e.DepBirthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("depBirthdate");

                entity.Property(e => e.DepRelationship)
                    .HasMaxLength(50)
                    .HasColumnName("depRelationship");

                entity.Property(e => e.DepSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("depSex")
                    .IsFixedLength(true);

                entity.HasOne(d => d.EmpSsnNavigation)
                    .WithMany(p => p.TblDependents)
                    .HasForeignKey(d => d.EmpSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDependent_tblEmployee");
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpSsn);

                entity.ToTable("tblEmployee");

                entity.Property(e => e.EmpSsn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("empSSN");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.DepNum).HasColumnName("depNum");

                entity.Property(e => e.EmpAddress)
                    .HasMaxLength(50)
                    .HasColumnName("empAddress");

                entity.Property(e => e.EmpBirthdate)
                    .HasColumnType("datetime")
                    .HasColumnName("empBirthdate");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .HasColumnName("empName");

                entity.Property(e => e.EmpSalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("empSalary");

                entity.Property(e => e.EmpSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("empSex")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpStartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("empStartdate");

                entity.Property(e => e.SupervisorSsn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("supervisorSSN");

                entity.HasOne(d => d.DepNumNavigation)
                    .WithMany(p => p.TblEmployees)
                    .HasForeignKey(d => d.DepNum)
                    .HasConstraintName("FK_tblEmployee_tblDepartment");

                entity.HasOne(d => d.SupervisorSsnNavigation)
                    .WithMany(p => p.InverseSupervisorSsnNavigation)
                    .HasForeignKey(d => d.SupervisorSsn)
                    .HasConstraintName("FK_tblEmployee_tblEmployee");
            });

            modelBuilder.Entity<TblLocation>(entity =>
            {
                entity.HasKey(e => e.LocNum);

                entity.ToTable("tblLocation");

                entity.Property(e => e.LocNum).HasColumnName("locNum");

                entity.Property(e => e.LocName)
                    .HasMaxLength(50)
                    .HasColumnName("locName");
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.HasKey(e => e.ProNum);

                entity.ToTable("tblProject");

                entity.Property(e => e.ProNum)
                    .ValueGeneratedNever()
                    .HasColumnName("proNum");

                entity.Property(e => e.DepNum).HasColumnName("depNum");

                entity.Property(e => e.LocNum).HasColumnName("locNum");

                entity.Property(e => e.ProName)
                    .HasMaxLength(50)
                    .HasColumnName("proName");

                entity.HasOne(d => d.DepNumNavigation)
                    .WithMany(p => p.TblProjects)
                    .HasForeignKey(d => d.DepNum)
                    .HasConstraintName("FK_tblProject_tblDepartment");

                entity.HasOne(d => d.LocNumNavigation)
                    .WithMany(p => p.TblProjects)
                    .HasForeignKey(d => d.LocNum)
                    .HasConstraintName("FK_tblProject_tblLocation");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("tblUser");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWorksOn>(entity =>
            {
                entity.HasKey(e => new { e.EmpSsn, e.ProNum });

                entity.ToTable("tblWorksOn");

                entity.Property(e => e.EmpSsn)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("empSSN");

                entity.Property(e => e.ProNum).HasColumnName("proNum");

                entity.Property(e => e.WorkHours).HasColumnName("workHours");

                entity.HasOne(d => d.EmpSsnNavigation)
                    .WithMany(p => p.TblWorksOns)
                    .HasForeignKey(d => d.EmpSsn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblWorksOn_tblEmployee");

                entity.HasOne(d => d.ProNumNavigation)
                    .WithMany(p => p.TblWorksOns)
                    .HasForeignKey(d => d.ProNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblWorksOn_tblProject");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
