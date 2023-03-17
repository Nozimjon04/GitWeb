using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IOrganizationFollowerRepository
{
    ValueTask<OrganizationFollower> InsertAsync(OrganizationFollower organizationFollower);
    ValueTask<OrganizationFollower> UpdateAsync(OrganizationFollower organization);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<OrganizationFollower> SelectByIdAsync(long id);   
    IQueryable<OrganizationFollower> SelectAllAsync();
}
