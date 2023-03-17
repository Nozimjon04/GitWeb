using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Repositories;

public class OrganizationFollowerRepository : IOrganizationFollowerRepository
{
    private readonly AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteAsync(long id)
    {
        var entity = await this.appDbContext.OrganizationsFollowers.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.OrganizationsFollowers.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
    }

    public  async ValueTask<OrganizationFollower> InsertAsync(OrganizationFollower organizationFollower)
    {
        var entity = await this.appDbContext.OrganizationsFollowers.AddAsync(organizationFollower);
        await this.appDbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public IQueryable<OrganizationFollower> SelectAllAsync()
    {
        return this.appDbContext.OrganizationsFollowers;
    }

    public async ValueTask<OrganizationFollower> SelectByIdAsync(long id)
    {

        var entity = await this.appDbContext.OrganizationsFollowers.FirstOrDefaultAsync(user => user.Id.Equals(id));
        return entity;
    }

    public async ValueTask<OrganizationFollower> UpdateAsync(OrganizationFollower organization)
    {
        var entity = await this.appDbContext.OrganizationsFollowers.FirstOrDefaultAsync(x => x.Id.Equals(organization.Id));
        if (entity is null)
        {
            return null;
        }
        entity.Id= organization.Id;
        entity.OrganizationFollowerId=organization.OrganizationFollowerId;
        entity.OrganizationId=organization.OrganizationId;
        entity.UserOrganization = organization.UserOrganization;
        entity.Organization = organization.Organization;
        entity.CreatedAt = organization.CreatedAt;
        entity.UpdatedAt = DateTime.Now;
        await this.appDbContext.SaveChangesAsync();
        return entity;
        
    }
}
