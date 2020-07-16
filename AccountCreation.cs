using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCreation
{
    class AccountCreation
    {
        static string getItem(string prompt)
        {
            ConsoleKey conf;

            Console.Write("What is your {0}: ", prompt);
            string user_name = Console.ReadLine();
            Console.WriteLine("Does this look right?: \"{0}\"", user_name);
            Console.Write("[Y/N]: ");
            conf = Console.ReadKey().Key;
            Console.WriteLine();


            while (conf != ConsoleKey.Y || conf != ConsoleKey.N)
            {
                if (conf == ConsoleKey.Y)
                {
                    return user_name;
                }
                else if (conf == ConsoleKey.N)
                {
                    Console.Clear();
                    Console.Write("What is your {0}: ", prompt);
                    user_name = Console.ReadLine();
                    Console.WriteLine("Does this look right?: \"{0}\"", user_name);
                    Console.Write("[Y/N]: ");
                    conf = Console.ReadKey().Key;
                    Console.WriteLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Does this look right?: \"{0}\"", user_name);
                    Console.Write("[Y/N]: ");
                    conf = Console.ReadKey().Key;
                    Console.WriteLine();
                }
            }

            return user_name;
        }

        static void Main(string[] args)
        {
            User new_user = new User();

            new_user.changeUsername(getItem("Username"));
            Console.Clear();
            new_user.changePassword(getItem("Password"));

            Console.Clear();

            Console.WriteLine("Password {0}:", new_user.getPassword());
            Console.WriteLine("Username {0}", new_user.getUsername());
        }
    }
}

class User
{
    private string username;
    private string password;

    public void changeUsername(string new_username)
    {
        username = new_username;
    }

    public void changePassword(string new_password)
    {
        password = new_password;
    }

    public string getUsername()
    {
        return username;
    }

    public string getPassword()
    {
        return password;
    }
}
