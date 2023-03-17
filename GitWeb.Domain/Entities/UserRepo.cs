using GitWeb.Domain.Commons;
using GitWeb.Domain.Enums;

namespace GitWeb.Domain.Entities;

public class UserRepo:Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    public string Name { get; set; }
    public ProgrammingType type { get; set; }
    public int StarCount { get; set; }

}