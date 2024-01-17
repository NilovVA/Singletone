using System;

namespace singletone
{
 
    public class User
    {
        static User user;
        protected User()
        {
            Console.WriteLine("Good day, user");
        }
        public static User Instance()
        {
            if (user == null)
                user = new User();
            else
                Console.WriteLine("What do you want to find?");
            return user;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            User a = User.Instance();
            User b = User.Instance();
        }
    }
}

