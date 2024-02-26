using Npgsql;

namespace PostgresCRUD
{
	public class Read
	{

        private string connectionString =
            "Host=localhost;Username=*username*;Password=*password*=;Database=*database name*";

             // Read By first name operation
        public void readByFirstName(string firstName)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // create 'read' sql statement
                var readByFirstName = "SELECT * FROM users WHERE firstname=(@value)";

                // make a new npgsql command
                using (var command = new NpgsqlCommand(readByFirstName, connection))
                {

                    // add query parameters
                    command.Parameters.AddWithValue("value", firstName);

                    // execute reader
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0));
                            Console.WriteLine(reader.GetString(1));
                            Console.WriteLine(reader.GetString(2));
                            Console.WriteLine("===================");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}

