using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Repositories;

public class OrganizationRepository : IOrganizationRepository
{
    private readonly AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<Organization> InsertAsync(Organization organization)
    {
        var entity=await this.appDbContext.Organizations.AddAsync(organization);
        await this.appDbContext.SaveChangesAsync();
        return entity.Entity;
    }
    public async ValueTask<Organization> UpdateAsync(Organization organization)
    {
        var entity = await this.appDbContext.Organizations.FirstOrDefaultAsync(x => x.Id.Equals(organization.Id));
        if (entity is null)
        {
            return null;
        }
        entity.Id= organization.Id;
        entity.Name= organization.Name;
        entity.User=organization.User;
        entity.Email=organization.Email;
        entity.UserId=organization.UserId;
        entity.CreatedAt=organization.CreatedAt;
        entity.UpdatedAt=DateTime.Now;
        entity.FollowerCount=organization.FollowerCount;
        await this.appDbContext.SaveChangesAsync();
        return entity;
    }
    public  async ValueTask<bool> DeleteAsync(long id)
    {
        var entity = await this.appDbContext.Organizations.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.Organizations.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;

        
    }

    public async ValueTask<Organization> SelectByIdAsync(long id)
    {
        var entity = await this.appDbContext.Organizations.FirstOrDefaultAsync(user => user.Id.Equals(id));
        return entity;
        
    }

    public IQueryable<Organization> SelectAllAsync()
    {
        return this.appDbContext.Organizations;
       
    }

}
