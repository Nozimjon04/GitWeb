using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IUserFollowerRepository
{
    ValueTask<UserFollower> InsertAsync(UserFollower userFollower);
    ValueTask<UserFollower> UpdateAsync(UserFollower userFollower);
    ValueTask<bool> DelateAsync(long id);
    ValueTask<UserFollower> SelectByIdAsync(long id);
    IQueryable<UserFollower> SelectAllAsync();
}
