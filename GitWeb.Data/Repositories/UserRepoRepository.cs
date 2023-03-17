using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Repositories;

public class UserRepoRepository : IUserRepoRepository
{
    private readonly AppDbContext appDbContext=new AppDbContext();
    public async ValueTask<UserRepo> InsertAsync(UserRepo userRepo)
    {
        var entity=await this.appDbContext.UsersRepos.AddAsync(userRepo);
        await this.appDbContext.SaveChangesAsync();
        return entity.Entity;
        
    }
    public async ValueTask<UserRepo> UpdateAsync(UserRepo userRepo)
    {
        var entity= await this.appDbContext.UsersRepos.FirstOrDefaultAsync(u=>u.Name==userRepo.Name);
        if(entity is null)
        {
            return null;
        }
        entity.Name= userRepo.Name;
        entity.User=userRepo.User;
        entity.UserId=userRepo.UserId;
        entity.CreatedAt = userRepo.CreatedAt;
        entity.UpdatedAt =DateTime.Now;
        entity.Id = userRepo.Id;
        entity.StarCount=userRepo.StarCount;
        entity.type = userRepo.type;
        return entity;
        
    }
    public async ValueTask<bool> DelateAsync(long id)
    {
       var entity=await this.appDbContext.UsersRepos.FirstOrDefaultAsync(x => x.Id == id);
        if (entity == null)
        {
            return false;
        }
        this.appDbContext.UsersRepos.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
    }
    public async ValueTask<UserRepo> SelectByIdaAsync(long id)
    {
    var entity = await this.appDbContext.UsersRepos.FirstOrDefaultAsync(u=>u.Id.Equals(id));
        return entity;
        
    }

    public  IQueryable<UserRepo> SelectAllAsync()
    {
        return this.appDbContext.UsersRepos;
  
    }


}
