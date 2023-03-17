using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Contexts;

public class AppDbContext:DbContext
{
    DbSet<Organization> Organizations { get; set; }
    DbSet<OrganizationFollower> OrganizationsFollowers { get;set; }
    DbSet<OrganizationMember> OrganizationsMembers { get; set;}
    DbSet<OrganizationRepository> OrganizationsRepositories { get; set;}
    DbSet<User> Users { get; set; }
    DbSet<UserFollower> UsersFollows { get; set; }
    DbSet<UserRepo> UsersRepos { get; set; }
    DbSet<UserRepoStar> UsersReposStars { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string path = "Server=NOZIMJON\\SQLEXPRESS; Database=GitWeb; Trusted_Connection=True;";
        optionsBuilder.UseSqlServer(path);
        
    }
}
