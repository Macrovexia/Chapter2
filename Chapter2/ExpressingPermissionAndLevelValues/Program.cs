using System;

namespace ExpressingPermissionAndLevelValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int level = random.Next(75);

            string permission = "Admin|Manager";
            string[] roles = permission.Split('|');
            string randomRole = roles[random.Next(roles.Length)];

            switch (randomRole)
            {
                case "Admin":
                    Console.WriteLine((level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
                    break;
                case "Manager":
                    Console.WriteLine((level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
                    break;
                default:
                    Console.WriteLine("You do not have sufficient privileges.");
                    break;
            }
        }
    }
}
