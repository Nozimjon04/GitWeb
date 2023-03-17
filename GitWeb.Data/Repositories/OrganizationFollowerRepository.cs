using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;

namespace GitWeb.Data.Repositories;

public class OrganizationFollowerRepository : IOrganizationFollowerRepository
{
    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationFollower> InsertAsync(OrganizationFollower organizationFollower)
    {
        throw new NotImplementedException();
    }

    public IQueryable<OrganizationFollower> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationFollower> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationFollower> UpdateAsync(OrganizationFollower organization)
    {
        throw new NotImplementedException();
    }
}
