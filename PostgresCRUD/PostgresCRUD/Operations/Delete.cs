using Npgsql;

namespace PostgresCRUD
{
	public class Delete
	{
		private string connectionString =
            "Host=localhost;Username=*username*;Password=*password*=;Database=*database name*s";

		public void deleteByFirstName(string firstName)
		{
			using(var connection = new NpgsqlConnection(connectionString))
			{

				// open database connection
				connection.Open();

				// create 'delete' query
				var deleteByFirstNameQuery =
					"DELETE FROM users WHERE firstname=(@value)";

				// create new npgsql command
				using(var command = new NpgsqlCommand(deleteByFirstNameQuery, connection))
				{
					try
					{
						// add parameters to query
						command.Parameters.AddWithValue("value", firstName);

						// execute the command
						command.ExecuteNonQuery();

						// log the result
						Console.WriteLine("User '" + firstName + "' and their contents have been deleted..");
						

                    }
                    catch(Exception ex) {
						Console.WriteLine("User '" + firstName + "' has not been deleted");
						Console.WriteLine("[ERROR] - " + ex.ToString());
					}
				}

				// close the database connection
				connection.Close();
			}
		}
    }
}

