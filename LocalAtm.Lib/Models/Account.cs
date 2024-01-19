using System.Text.Json.Serialization;

namespace LocalAtm.Lib.Models;

public class Account
{
    public string CardNumber { get; set; } = null!;
    public int Pin { get; set; }
    public string FullName { get; set; } = null!;
    public int Balance { get; set; }
}
