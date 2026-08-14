using HYBRIDAPP.Shared.DTOs;
using HYBRIDAPP.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HYBRIDAPP.Shared.Interfaces;

public interface IUserService
{
    Task<List<Register>> GetAllUsersAsync();
    Task<Register?> GetUserByIdAsync(int id);
    Task AddUserAsync(CreateUserDto dto);
    Task UpdateUserAsync(UpdateUserDto dto);
    Task DeleteUserAsync(int id);
}
