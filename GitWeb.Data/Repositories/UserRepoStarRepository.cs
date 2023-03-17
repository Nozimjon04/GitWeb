using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GitWeb.Data.Repositories;

public class UserRepoStarRepository : IUserRepoStarRepository
{
    private readonly AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteAsync(long id)
    {
        var entity = await this.appDbContext.UsersReposStars.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.UsersReposStars.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
       
    }

    public async ValueTask<UserRepoStar> InsertAsync(UserRepoStar userRepoStar)
    {
        var entity = await this.appDbContext.UsersReposStars.AddAsync(userRepoStar);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
        
    }

    public IQueryable<UserRepoStar> SelectAllAsync()
    {
        return this.appDbContext.UsersReposStars;
    }

    public async ValueTask<UserRepoStar> SelectByIdAsync(long id)
    {
        var entity = await this.appDbContext.UsersReposStars.FirstOrDefaultAsync(user => user.Id.Equals(id));
        return entity;
    }

    public async ValueTask<UserRepoStar> UpdateAsync(UserRepoStar userRepo)
    {
        var entity= await this.appDbContext.UsersReposStars.FirstOrDefaultAsync(u=>u.Id.Equals(userRepo.Id));
        if(entity is null)
        {
            return null;
        }
        this.appDbContext.UsersReposStars.Update(entity);
        await this.appDbContext.SaveChangesAsync();
        return entity;
    }
}
