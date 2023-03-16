using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class OrganizationMember:Auditable
{
    public long OrganizationId { get; set; }
    public Organization Organization { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }

}
