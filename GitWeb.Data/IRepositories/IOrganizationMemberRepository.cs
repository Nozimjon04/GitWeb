using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IOrganizationMemberRepository
{
    ValueTask<OrganizationMember> InsertAsync(OrganizationMember organizationMember);
    ValueTask<OrganizationMember> UpdateAsync(OrganizationMember organization);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<OrganizationMember> SelectByIdAsync(long id);
    IQueryable<OrganizationMember>  SelectAllAsync();
}
