
/* name = gurmandeep singh
 * Question number 1
 * student id = 30008833
 * */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p1=new Program(); //Object created to access methods val_uname and val_pwd
            string reply;
            do
            {
                Console.Clear();
                Console.Write("\t\t\t****Welcome to****\n");
                Console.Write("\t\t****The Rotorua Thermal Holiday park****\n");
                Console.Write("\n\nEnter your user name : ");
                string userName = Console.ReadLine();   // username from user
                if (p1.val_uname(userName)==1)          //Checks from username to be at least 8 characters long 
                {
                    Console.Write("Username must be at least 8 characters long");
                }
                else
                {
                    Console.Write("Enter your password  : ");
                    string password = Console.ReadLine();   //Gets a password from user
                    Console.Write("Enter your password  : ");
                    string confirm_password = Console.ReadLine(); //Asks user to re-enter the password
                    if (p1.val_pwd(password, confirm_password) == 1)  //checks if both the passwords match by calling val_pwd method
                    {
                        Console.Write("Username and Password have been accepted and set.");
                    }
                    else if (p1.val_pwd(password, confirm_password) == 0)  //checks if both the passwords are atleast 8 characters long by calling val_pwd method
                    {
                        Console.Write("Password must be at least 8 characters long");
                    }
                    else
                    {
                        Console.Write("Password Do not Match");
                    }
                }
                Console.Write("\n\n");
                Console.Write("Do You Want To Continue? Y/N : ");   //Asks user to again start the process or to exit
                reply = Console.ReadLine();
                if (reply == "y" || reply == "Y")
                {
                    continue;
                }
                else if (reply == "n" || reply == "N")
                {
                    Console.Write("\n\n");
                    Console.Write("Thank You For Using This Software.");
                    Console.Write("\n\n");
                    break;
                }
            } while (reply!="n");
            Console.ReadKey(true);
        }

        int val_uname(string un)    //Method to check the username to be at least 8 characters long
        {
            int n = un.Length;
            int flag = 0;
            if(n<8)
            {
                flag = 1;
            }
            return flag;
        }

        int val_pwd(string s1, string s2)   ////Method to check the username to be at least 8 characters long and if both the passwords match
        {
            int flag = -1;
            if (s1.Length >= 8 && s2.Length >= 8)
            {
                if(s1 == s2)
                {
                    flag = 1;
                }
            }
            else
            {
                flag = 0;
            }
            return flag;
        }
    }
}
