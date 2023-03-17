using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Repositories;

public class OrganizationRepoRepository : IOrganizationRepoRepository
{
    private readonly AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteAsync(long id)
    {
        var entity = await this.appDbContext.OrganizationsRepos.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.OrganizationsRepos.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
    }

    public  async ValueTask<OrganizationRepo> InsertAsync(OrganizationRepo organizationRepo)
    {
        var entity = await this.appDbContext.OrganizationsRepos.AddAsync(organizationRepo);
        await this.appDbContext.SaveChangesAsync();
        return entity.Entity;
       
    }

    public IQueryable<OrganizationRepo> SelectAllAsync()
    {
        return this.appDbContext.OrganizationsRepos;
    }

    public async ValueTask<OrganizationRepo> SelectByIdAsync(long id)
    {
        var entity = await this.appDbContext.OrganizationsRepos.FirstOrDefaultAsync(user => user.Id.Equals(id));
        return entity;
    }

    public async ValueTask<OrganizationRepo> UpdateAsync(OrganizationRepo organizationRepo)
    {
        var entity = await this.appDbContext.OrganizationsRepos.FirstOrDefaultAsync(x => x.Id.Equals(organizationRepo.Id));
        if (entity is null)
        {
            return null;
        }
        entity.Id= organizationRepo.Id;
        entity.Name= organizationRepo.Name;
        entity.StarCount= organizationRepo.StarCount;
        entity.UpdatedAt=DateTime.Now;
        entity.CreatedAt = organizationRepo.CreatedAt;
        entity.OrganizationId = organizationRepo.Id;
        entity.Organization = organizationRepo.Organization;
        entity.Type = organizationRepo.Type;
       await this.appDbContext.SaveChangesAsync();
        return entity;
        
    }
}
