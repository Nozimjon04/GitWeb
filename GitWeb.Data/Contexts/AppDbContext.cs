using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Contexts;

public class AppDbContext:DbContext
{
   public DbSet<Organization> Organizations { get; set; }
   public DbSet<OrganizationFollower> OrganizationsFollowers { get;set; }
   public DbSet<OrganizationMember> OrganizationsMembers { get; set;}
   public DbSet<OrganizationRepo> OrganizationsRepos { get; set;}
   public DbSet<User> Users { get; set; }
   public DbSet<UserFollower> UsersFollows { get; set; }
   public DbSet<UserRepo> UsersRepos { get; set; }
   public DbSet<UserRepoStar> UsersReposStars { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Server=NOZIMJON\\SQLEXPRESS; Database=GitWeb; Trusted_Connection=True;";
        optionsBuilder.UseSqlServer(path);
        
    }
}
