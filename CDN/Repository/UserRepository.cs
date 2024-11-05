using CDN.Data;
using CDN.Entities;
using CDN.Interface;
using Microsoft.EntityFrameworkCore;

namespace CDN.Repository;

public class UserRepository : IUserRepository
{
    private readonly CDNDbContext _context;

    public UserRepository(CDNDbContext context)
    {
        _context = context;
    }

  
    // Get All User 
    public IQueryable<User> GetUsers()
    {
        return _context.Users;
    }

    // Get a user by Id
    public async Task<User> GetUserById(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    // Add a new user
    public async Task<bool> AddUser(User user)
    {
        await _context.Users.AddAsync(user);
       return await _context.SaveChangesAsync()>0;
    }

    // Update an existing user
    public async Task<bool> UpdateUser(User user)
    {
        _context.Entry(user).State = EntityState.Modified;
        return await _context.SaveChangesAsync()>0;
    }

    // Delete a user by Id
    public async Task<bool> DeleteUser(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
           return await _context.SaveChangesAsync()>0;
        }

        return false;
    }
}