namespace LocalAtm.Lib.Models;

public class Account
{
    public string AccountNumber { get; set; } = null!;
    public int Pin { get; set; }
    public string FullName { get; set; } = null!;
    public int Balance { get; set; }
}
