using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IUserRepoStarRepository
{
    ValueTask<UserRepoStar> InsertAsync(UserRepoStar userRepoStar);
    ValueTask<UserRepoStar> UpdateAsync(UserRepoStar userRepo);
    ValueTask<bool> DeleteAsync(long id);
    ValueTask<UserRepoStar> SelectByIdAsync(long id);
    IQueryable<UserRepoStar> SelectAllAsync();

}
