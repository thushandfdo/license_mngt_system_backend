using license_mngt_system_backend.Models.Entities;

namespace license_mngt_system_backend.Interfaces.Services;

public interface IUserService
{
    Task<User> GetUserById(int id);
    Task<IEnumerable<User>> GetUsers();
    Task<User> InsertUser(User user);
    Task<User> UpdateUser(User user);
    Task<User> DeleteUser(int id);
    Task<bool> IsUserExists(int id);
}