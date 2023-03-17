using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace GitWeb.Data.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext appDbContext= new AppDbContext();
    public async ValueTask<User> InsertAsync(User user)
    {
        EntityEntry<User> entity = await this.appDbContext.Users.AddAsync(user);
        await appDbContext.SaveChangesAsync();
        return entity.Entity;
        
    }
    public async ValueTask<User> UpdateAsync(User user)
    {
        var entity = await this.appDbContext.Users.FirstOrDefaultAsync(x=>x.Id.Equals(user.Id));
        if(entity is null)
        {
            return null;
        }
        entity.FirstName = user.FirstName;
        entity.LastName = user.LastName;
        entity.Email = user.Email;
        entity.Password = user.Password;
        entity.Bio = user.Bio;
        entity.Address = user.Address;
        entity.CreatedAt = user.CreatedAt;
        entity.UpdatedAt = DateTime.Now;
        await this.appDbContext.SaveChangesAsync();
        return entity;
    }
    public async ValueTask<bool> DelateAsync(long id)
    {
        var entity = await this.appDbContext.Users.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.Users.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
        
       
    }
    public async ValueTask<User> SelectByIdAsync(long id)
    {
        var entity=await this.appDbContext.Users.FirstOrDefaultAsync(user=>user.Id.Equals(id));
        return entity;
    }

    public IQueryable<User> SelectAllAsync()
    {
        return this.appDbContext.Users;
    }


}
