using Npgsql;

namespace PostgresCRUD
{
	public class Update
	{
		private string connectionString =
            "Host=localhost;Username=*username*;Password=*password*=;Database=*database name*";

		public void updateFirstName(string firstName, string updatedFirstName)
		{
			using(var connection = new NpgsqlConnection(connectionString))
			{
				// connect to database
				connection.Open();

				// create delete query
				var deleteByFirstName =
					"UPDATE users SET firstname=(@value1) WHERE firstname=(@value2)";
							
				using(var command = new NpgsqlCommand(deleteByFirstName, connection))
				{
					// add parameters
					command.Parameters.AddWithValue("value1", updatedFirstName);
                    command.Parameters.AddWithValue("value2", firstName);
					Console.WriteLine("User first name has been updated from '" + firstName + "'" + " to '"
						+ updatedFirstName + "'");

                    // execute the command
                    command.ExecuteNonQuery();
				}
			}
		}

    }
}

