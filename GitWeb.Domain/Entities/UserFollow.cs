using GitWeb.Domain.Commons;

namespace GitWeb.Domain.Entities;

public class UserFollow:Auditable
{
    public long FollowerId { get; set; }
    public User UserFollower { get; set; }
    public long FollowingId { get; set; }
    public User UserFollowing { get; set; }
    
}
