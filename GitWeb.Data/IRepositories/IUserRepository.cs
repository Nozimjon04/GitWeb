using GitWeb.Domain.Entities;

namespace GitWeb.Data.IRepositories;

public interface IUserRepository
{
    ValueTask<User> InsertAsync(User user);
    ValueTask<User> UpdateAsync(User user);
    ValueTask<bool> DelateAsync(long id);
    ValueTask<User> SelectByIdAsync(long id);
    IQueryable<User> SelectAllAsync();

}
