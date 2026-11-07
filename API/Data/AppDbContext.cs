using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class AppDbContext(DbContextOptions option) : DbContext(option)
{
    public DbSet<AppUser> Users { get; set; }
}
