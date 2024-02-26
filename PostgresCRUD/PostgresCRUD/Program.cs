namespace PostgresCRUD{
    public class Program {
        public static void Main(string[] args){

            // initiate user
            User user = new User("Alex", "Biros", "08-07-1972");
            TestConnection tc = new TestConnection();
            Create create = new Create();
            Read read = new Read();
            Update update = new Update();
            Delete delete = new Delete();



            tc.testConnection();

            // create method
            create.create(user.FirstName, user.LastName, user.Dob);

            // read method
            read.readByFirstName(user.FirstName);

            // delete method
            delete.deleteByFirstName(user.FirstName);

            // update method
            update.updateFirstName(user.FirstName, "Ryan");

        }
    }
}
