using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IUserRepoRepository
{
    ValueTask<UserRepo> InsertAsync(UserRepo userRepo);
    ValueTask<UserRepo> UpdateAsync(UserRepo userRepo);
    ValueTask<bool> DelateAsync(long id);
    ValueTask<UserRepo> SelectByIdaAsync(long id);
    IQueryable<UserRepo> SelectAllAsync();
}
