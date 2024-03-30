using license_mngt_system_backend.Data;
using license_mngt_system_backend.Exceptions;
using license_mngt_system_backend.Interfaces.Services;
using license_mngt_system_backend.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace license_mngt_system_backend.Services;

public class UserService : IUserService
{
    private readonly DataContext _context;
    private DbSet<User> Users { get; set; }

    public UserService(DataContext context)
    {
        _context = context;
        Users = context.Users;
    }

    public async Task<User> GetUserById(int id)
    {
        var user = await Users.FindAsync(id);

        return user ?? throw new NotFoundException("User not found");
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        return await Users.ToListAsync();
    }

    public async Task<User> InsertUser(User newUser)
    {
        Users.Add(newUser);
        await _context.SaveChangesAsync();

        var insertedUser = await Users.FirstOrDefaultAsync(user => user.UserName == newUser.UserName);

        return insertedUser ??
               throw new NotFoundException($"User with username {newUser.UserName} not found");
    }

    public async Task<User> UpdateUser(User updatedUser)
    {
        _context.Entry(updatedUser).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        var insertedUser = await Users.FirstOrDefaultAsync(user => user.UserName == updatedUser.UserName);

        return insertedUser ??
               throw new NotFoundException($"User with username {updatedUser.UserName} not found");
    }

    public async Task<User> DeleteUser(int id)
    {
        var user = await Users.FindAsync(id);

        if (user == null)
        {
            throw new NotFoundException("User not found");
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<bool> IsUserExists(int id)
    {
        return await Users.AnyAsync(user => user.UserId == id);
    }
}