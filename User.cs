using System;
using System.Linq;

public class User
{
    private string _userName;
    private string _password;

    public string UserName
    {
        get => _userName;
        set
        {
            while (true)
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6 || value.Length > 25)
                {
                    Console.WriteLine("UserName must be between 6 and 25 characters. Please enter again:");
                    value = Console.ReadLine();
                }
                else
                {
                    _userName = value;
                    break;
                }
            }
        }
    }

    public string Password
    {
        get => _password;
        set
        {
            while (true)
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 8 || value.Length > 25)
                {
                    Console.WriteLine("Password must be between 8 and 25 characters. Please enter again:");
                    value = Console.ReadLine();
                }
                else if (!HasDigit(value))
                {
                    Console.WriteLine("Password must contain at least one digit. Please enter again:");
                    value = Console.ReadLine();
                }
                else if (!HasUpper(value))
                {
                    Console.WriteLine("Password must contain at least one uppercase letter. Please enter again:");
                    value = Console.ReadLine();
                }
                else if (!HasLower(value))
                {
                    Console.WriteLine("Password must contain at least one lowercase letter. Please enter again:");
                    value = Console.ReadLine();
                }
                else
                {
                    _password = value;
                    break;
                }
            }
        }
    }

    public User(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }

    public bool HasDigit(string value)
    {
        return value.Any(char.IsDigit);
    }

    public bool HasUpper(string value)
    {
        return value.Any(char.IsUpper);
    }

    public bool HasLower(string value)
    {
        return value.Any(char.IsLower);
    }
}


