using CDN.Entities;
using Microsoft.EntityFrameworkCore;

namespace CDN.Data;

public class CDNDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    
}