using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeReporting.Models;

namespace TimeReporting.Data;

public class AppDbContext : IdentityDbContext<CustomUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}