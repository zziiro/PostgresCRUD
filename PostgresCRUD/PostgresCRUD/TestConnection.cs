using System;
using Npgsql;

namespace PostgresCRUD
{
	public class TestConnection
	{
		private string connectionString =
            "Host=localhost;Username=*username*;Password=*password*=;Database=*database name*";

		public void testConnection()
		{
			using(var connection = new NpgsqlConnection(connectionString))
			{
				try {
                    connection.Open();
					Console.WriteLine("Connection Successful..");
                }catch(Exception ex)
				{
					Console.WriteLine("Connection unsuccessful..");
					Console.WriteLine("[ERROR] - " + ex.ToString());
				}
            }
		}
    }
}

