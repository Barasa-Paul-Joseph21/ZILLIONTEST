using HYBRIDAPP.Shared.DTOs;
using HYBRIDAPP.Shared.Models;
using HYBRIDAPP.Web.Data;
using HYBRIDAPP.Web.Services;
using HYBRIDAPP.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HYBRIDAPP.Web.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Register>> GetAllUsersAsync()
    {
        return await _context.Registers
            .AsNoTracking()
            .OrderBy(x => x.Id)
            .ToListAsync();
    }

    public async Task<Register?> GetUserByIdAsync(int id)
    {
        return await _context.Registers
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddUserAsync(CreateUserDto dto)
    {
        var user = new Register
        {
            Name = dto.Name,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            Gender = dto.Gender
        };

        _context.Registers.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUserAsync(UpdateUserDto dto)
    {
        var user = await _context.Registers.FindAsync(dto.Id);

        if (user is null)
            throw new InvalidOperationException("User not found.");

        user.Name = dto.Name;
        user.Email = dto.Email;
        user.PhoneNumber = dto.PhoneNumber;
        user.Gender = dto.Gender;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserAsync(int id)
    {
        var user = await _context.Registers.FindAsync(id);

        if (user is null)
            throw new InvalidOperationException("User not found.");

        _context.Registers.Remove(user);
        await _context.SaveChangesAsync();
    }
}
