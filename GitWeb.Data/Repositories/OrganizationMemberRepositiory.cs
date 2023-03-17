using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;

namespace GitWeb.Data.Repositories;

public class OrganizationMemberRepositiory : IOrganizationMemberRepository
{
    public ValueTask<bool> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationMember> InsertAsync(OrganizationMember organizationMember)
    {
        throw new NotImplementedException();
    }

    public IQueryable<OrganizationMember> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationMember> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<OrganizationMember> UpdateAsync(OrganizationMember organization)
    {
        throw new NotImplementedException();
    }
}
