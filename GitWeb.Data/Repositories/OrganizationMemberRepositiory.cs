using GitWeb.Data.Contexts;
using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GitWeb.Data.Repositories;

public class OrganizationMemberRepositiory : IOrganizationMemberRepository
{
    private readonly AppDbContext appDbContext = new AppDbContext();
    public async ValueTask<bool> DeleteAsync(long id)
    {
        var entity = await this.appDbContext.OrganizationsMembers.FirstOrDefaultAsync(user => user.Id.Equals(id));
        if (entity is null)
        {
            return false;
        }
        this.appDbContext.OrganizationsMembers.Remove(entity);
        await this.appDbContext.SaveChangesAsync();
        return true;
    }

    public async ValueTask<OrganizationMember> InsertAsync(OrganizationMember organizationMember)
    {
        var entity = await this.appDbContext.OrganizationsMembers.AddAsync(organizationMember);
        await this.appDbContext.SaveChangesAsync();
        return entity.Entity;
    }

    public IQueryable<OrganizationMember> SelectAllAsync()
    {
        return this.appDbContext.OrganizationsMembers;
    }

    public async ValueTask<OrganizationMember> SelectByIdAsync(long id)
    {
        var entity = await this.appDbContext.OrganizationsMembers.FirstOrDefaultAsync(user => user.Id.Equals(id));
        return entity;
    }

    public async ValueTask<OrganizationMember> UpdateAsync(OrganizationMember organization)
    {
        var entity = await this.appDbContext.OrganizationsMembers.FirstOrDefaultAsync(x => x.Id.Equals(organization.Id));
        if (entity is null)
        {
            return null;
        }
        entity.Id = organization.Id;
        entity.OrganizationId = organization.Id;
        entity.CreatedAt = organization.CreatedAt;
        entity.UpdatedAt = DateTime.Now;
        entity.Organization = organization.Organization;
        await this.appDbContext.SaveChangesAsync();
        return entity;
    }
}
