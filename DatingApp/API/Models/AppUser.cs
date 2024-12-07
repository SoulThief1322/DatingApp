using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class AppUser
{
    [Key]
    public int Id { get; set; }
    public required string Username { get; set; } = string.Empty;
}
