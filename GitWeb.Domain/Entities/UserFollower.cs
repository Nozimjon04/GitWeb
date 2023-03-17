using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class UserFollower:Auditable
{
    public long FollowerId { get; set; }
    public User FollowerUser { get; set; }
    public long FollowingId { get; set; }
    public User FollowingUser { get; set; }
   
    
}
