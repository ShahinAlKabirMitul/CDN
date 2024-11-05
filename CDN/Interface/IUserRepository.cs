using CDN.Entities;

namespace CDN.Interface;

public interface IUserRepository
{
    IQueryable<User> GetUsers();
  
    Task<User> GetUserById(int id);
    Task<bool> AddUser(User user);
    Task<bool>  UpdateUser(User user);
    Task<bool> DeleteUser(int id);
}