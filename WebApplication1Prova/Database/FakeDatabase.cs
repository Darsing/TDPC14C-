namespace WebApplication1Prova.Database
{
    public class FakeDatabase
    {
        private static int GlobalId = 0;
        public List<User> Users { get; set; }

        public FakeDatabase()
        {
            Users = new List<User>();

            AddUserInternal1(new User
            {
                userName = "userName1",
                Password = "Password1",
                Name = "Name1",
                Surname = "Surname1"
            });

            AddUserInternal1(new User
            {
                userName = "userName2",
                Password = "Password2",
                Name = "Name2",
                Surname = "Surname2"
            });

            AddUserInternal1(new User
            {
                userName = "userName3",
                Password = "Password3",
                Name = "Name3",
                Surname = "Surname3"
            });

            AddUserInternal1(new User
            {
                userName = "userName4",
                Password = "Password4",
                Name = "Name4",
                Surname = "Surname4"
            });
        }


        public void AddUser(User user)
        {
            Users.Add(user);
        }

        private void AddUserInternal1(User user)
        {
            GlobalId++;
            user.IdUser = GlobalId;
            Users.Add(user);
        }

        
    }
    public class User
    {
        public int IdUser { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        

    }
}
