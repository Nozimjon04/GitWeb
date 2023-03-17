using GitWeb.Data.IRepositories;
using GitWeb.Domain.Entities;

namespace GitWeb.Data.Repositories;

public class UserFollowerRepository : IUserFollowerRepository
{
    public ValueTask<bool> DelateAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserFollower> InsertAsync(UserFollower userFollower)
    {
        throw new NotImplementedException();
    }

    public IQueryable<UserFollower> SelectAllAsync()
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserFollower> SelectByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public ValueTask<UserFollower> UpdateAsync(UserFollower userFollower)
    {
        throw new NotImplementedException();
    }
}
