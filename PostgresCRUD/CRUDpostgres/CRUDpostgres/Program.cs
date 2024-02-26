
using System;
using Npgsql;
using CRUDpostgres.Model;

namespace CRUDpostgres;

public class Program
{
    public static void Main(string[] args)
    {
        CreateUser();
    }

    /* [C]reate new user by getting information */
    public static void CreateUser()
    {

        // prompt user
        Console.WriteLine("First Name: ");
        string? firstName = Console.ReadLine();

        Console.WriteLine("Last Name: ");
        string? lastName = Console.ReadLine();

        Console.WriteLine("Phone Number: ");
        string? phoneNumber = Console.ReadLine();

        Console.WriteLine("Email: ");
        string? email = Console.ReadLine();

        Console.WriteLine("Username: ");
        string? username = Console.ReadLine();

        Console.WriteLine("Password: ");
        string? password = Console.ReadLine();

        PersonModel _personModel = new()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Username = username,
            Password = password
        };



    }

}