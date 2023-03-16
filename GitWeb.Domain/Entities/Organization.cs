using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class Organization:Auditable
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int FollowerCount { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }

}
