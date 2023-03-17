using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GitWeb.Data.Repositories;

public class UserFollowerRepository : IUserFollowerRepository
{
    private readonly AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<UserFollower> InsertAsync(UserFollower userFollower)
    {
        var entity = await this.appDbContext.UsersFollows.AddAsync(userFollower);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public async ValueTask<UserFollower> UpdateAsync(UserFollower userFollower)
    {
        var entity=await this.appDbContext.UsersFollows.FirstOrDefaultAsync(u=>u.Id.Equals(userFollower.Id));
        if (entity is null)
        {
            return null;
        }
        entity.Id= userFollower.Id;
        entity.FollowingId = userFollower.FollowingId;
        entity.FollowingUser=userFollower.FollowingUser;
        entity.CreatedAt = userFollower.CreatedAt;
        entity.UpdatedAt = DateTime.Now;
        entity.FollowerUser = userFollower.FollowerUser;
        entity.FollowingUser = userFollower.FollowingUser;
        await this.appDbContext.SaveChangesAsync();
        return entity;
        
    }
    public async ValueTask<bool> DelateAsync(long id)
    {
        var entity = await this.appDbContext.UsersFollows.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.UsersFollows.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
       
    }
    public async ValueTask<UserFollower> SelectByIdAsync(long id)
    {
        var entity = await this.appDbContext.UsersFollows.FirstOrDefaultAsync(user => user.Id.Equals(id));
        return entity;
        
    }
    public IQueryable<UserFollower> SelectAllAsync()
    {
        return this.appDbContext.UsersFollows;
        
    }

}
