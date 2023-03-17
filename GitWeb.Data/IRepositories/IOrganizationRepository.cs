using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IOrganizationRepository
{
    ValueTask<Organization> InsertAsync(Organization organization);
    ValueTask<Organization> UpdateAsync(Organization organization);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<Organization> SelectByIdAsync(long id);
    IQueryable<Organization> SelectAllAsync();

}
