namespace PostgresCRUD
{
	public class User
	{
		private string firstName = string.Empty;
		private string lastName = string.Empty;
		private string dob = string.Empty;

		public User(string firstName, string lastName, string dob)
		{
			FirstName = firstName;
			LastName = lastName;
			Dob = dob;
		}

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		public string Dob
		{
			get { return dob; }
			set { dob = value; }
		}
	}
}

