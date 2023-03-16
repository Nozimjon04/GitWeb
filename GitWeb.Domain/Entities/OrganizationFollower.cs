using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class OrganizationFollower:Auditable
{
    public long OrganizationId { get; set; }
    public Organization Organization { get; set; }
    public long OrganizationFollowerId { get;set; }
    public User UserOrganization { get; set; }

}
