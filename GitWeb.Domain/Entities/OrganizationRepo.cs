using GitWeb.Domain.Commons;
using GitWeb.Domain.Enums;

namespace GitWeb.Domain.Entities;

public class OrganizationRepo:Auditable
{
    public long OrganizationId { get; set; }
    public Organization Organization { get; set; }
    public string Name { get; set; }
    public ProgrammingType Type { get; set; }
    public int StarCount { get; set; }

}
