using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class AppUser
{
    [Key]
    public int Id { get; set; }
    public required string Username { get; set; } = string.Empty;
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
