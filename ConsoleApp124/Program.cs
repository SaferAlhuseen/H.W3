using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    public class UserAccount
    {
public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserAccount(string email, string username, string password)
        {
            Email = email;
            Username = username;
            Password = password;
        }
        //********************************************************************
        public UserAccount(UserAccount cont)
        {
            Email = cont.Email;
            Username = cont.Username;
            Password = cont.Password;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList accounts = new ArrayList();
            //****************************************************
            accounts.Add(new UserAccount("user1@gmail.com", "user1",
            "password1"));
            accounts.Add(new UserAccount("user2@gmail.com", "user2",
            "password2"));
            accounts.Add(new UserAccount("user3@gmail.com", "user3",
            "password3"));
            //*********************************************************
            Console.WriteLine("Enter Username:");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string inputPassword = Console.ReadLine();
            //**********************************************************
            bool inValid = false;
            foreach (UserAccount account in accounts)
            {
                if (account.Username == inputUsername && account.Password == inputPassword)
                {
                    inValid = true;
                    break;
                }
            }
            if (inValid)
            {
                Console.WriteLine("Correct ");
            }
            else
            {
                Console.WriteLine("Invalid credentials**");
            }
            Console.ReadLine();
        }
    }
}
