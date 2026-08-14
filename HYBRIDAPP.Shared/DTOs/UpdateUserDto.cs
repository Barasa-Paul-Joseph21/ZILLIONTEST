using System;
using System.Collections.Generic;
using System.Text;

namespace HYBRIDAPP.Shared.DTOs;

public class UpdateUserDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;
}
