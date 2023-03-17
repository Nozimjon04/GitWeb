using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;

namespace GitWeb.Data.Repositories;

public class OrganizationRepoRepository : IOrganizationRepoRepository
{
    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationRepo> InsertAsync(OrganizationRepo organizationRepo)
    {
        throw new NotImplementedException();
    }

    public IQueryable<OrganizationRepo> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationRepo> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationRepo> UpdateAsync(OrganizationRepo organizationRepo)
    {
        throw new NotImplementedException();
    }
}
