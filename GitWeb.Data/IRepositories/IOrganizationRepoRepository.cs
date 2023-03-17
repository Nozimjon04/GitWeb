using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IOrganizationRepoRepository
{
    ValueTask<OrganizationRepo> InsertAsync(OrganizationRepo organizationRepo);
    ValueTask<OrganizationRepo> UpdateAsync(OrganizationRepo organizationRepo);
    ValueTask<bool> DeleteAsync(long id);    
    ValueTask<OrganizationRepo> SelectByIdAsync(long id);
    IQueryable<OrganizationRepo> SelectAllAsync();
}
