using inventor.Components.Pages;
using inventor.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using inventor.Models;    // <---  Added assuming Inventor is in Models

namespace inventor.Data; // <--- Changed to match your project likely

public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // Inherit from IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Models.inventor> inventors { get; set; }  // This is the DbSet
}