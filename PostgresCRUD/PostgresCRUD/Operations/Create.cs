using Npgsql;

namespace PostgresCRUD
{
	public class Create
	{
		private string connectionString =
            "Host=localhost;Username=*username*;Password=*password*=;Database=*database name*";

		// Create operation
		public void create(string firstName, string lastName, string dob)
		{
			using(var connection = new NpgsqlConnection(connectionString))
			{
				try
				{
                    // create a connection to the database
                    connection.Open();

                    // create the 'create' sql statement
                    var createQuery =
                        "INSERT INTO users (firstname, lastname, dob) VALUES (@value1, @value2, @value3)";

                    // query logic
                    using (var command = new NpgsqlCommand(createQuery, connection))
                    {
                        command.Parameters.AddWithValue("value1", firstName);
                        command.Parameters.AddWithValue("value2", lastName);
                        command.Parameters.AddWithValue("value3", dob);

                        //execute the query
                        command.ExecuteNonQuery();

                        // log completion
                        Console.WriteLine("First Name: " + firstName);
                        Console.WriteLine("Last Name: " + lastName);
                        Console.WriteLine("Date of Birth: " + lastName);
                        Console.WriteLine("User has been successfully added..");

                    }

                    // close the database connection
                    connection.Close();

                } catch(Exception ex)
                {
                    Console.WriteLine("There has been an error trying to create the user..");
                    Console.WriteLine("[ERROR] - " + ex.ToString());
                }
				
			}
		}
	}
}

