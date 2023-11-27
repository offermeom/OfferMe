using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace API.Data;
public partial class OMContext : DbContext
{
    public OMContext() {}
    [ActivatorUtilitiesConstructor]
    public OMContext(DbContextOptions<OMContext> options) : base(options) {}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
    public virtual DbSet<User>? Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.ID);
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())").HasColumnType("datetime").ValueGeneratedOnAdd().HasColumnName("Created_at");
            entity.Property(e => e.GSTIN).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Mail).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Number).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Password).HasMaxLength(100).IsUnicode(false);
        });
        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}