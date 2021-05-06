using Microsoft.AspNetCore.Identity;
using System;

namespace GeneratePasswordHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password to be hashed:");
            string password = Console.ReadLine();
            var passwordHasher = new PasswordHasher<string>();
            Console.WriteLine(passwordHasher.HashPassword(null, password));
            Console.ReadLine();
        }
    }
}
