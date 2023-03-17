using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;

namespace GitWeb.Data.Repositories;

public class OrganizationRepository : IOrganizationRepository
{
    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Organization> InsertAsync(Organization organization)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Organization> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<Organization> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Organization> UpdateAsync(Organization organization)
    {
        throw new NotImplementedException();
    }
}
