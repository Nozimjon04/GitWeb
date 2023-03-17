using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class UserRepoStar:Auditable
{
    //public long UserId { get; set; }
    //public User User { get; set; }
    public long UserRepoId { get; set; }
    public UserRepo userRepo { get; set; }


}
