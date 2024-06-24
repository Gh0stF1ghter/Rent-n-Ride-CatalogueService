using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class UsersDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
{
    public DbSet<UserEntity> Clients { get; set; }
}