using license_mngt_system_backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace license_mngt_system_backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public required DbSet<User> Users { get; set; }
}