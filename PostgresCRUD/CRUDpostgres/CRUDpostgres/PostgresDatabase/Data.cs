using System;
using Npgsql;

namespace CRUDpostgres.PostgresDatabase;
public class Data
{
	public Data()
	{
	}

    /* [C]reate new user */
    public static void CreateUser()
    {
        PostgresSetUp();

        
    }


    /* [R]ead user*/
    public static void ReadUser()
    {
        PostgresSetUp();
    }



    /* [U]pdate user*/
    public static void UpdateUser()
    {
        PostgresSetUp();
    }



    /* [D]elete user*/
    public static void DeleteUser() {
        PostgresSetUp();

    }


    /* Set Up postgres connection */
    public static async void PostgresSetUp()
    {
        const string ConnectionString = "Host=localhost;Username=postgres;Password=#c#bzziiro4.15kd";
        await using var connection = new NpgsqlConnection(ConnectionString);
        connection.Open();
    }
}


