using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Standard for password
            int minLength = 10;
            string uppercase = "QWERTYUIOPASDFGHJKLZCXVBNM";
            string lowercase = "qwertyuiopasdfghjklzxcvbnm";
            string digits = "1234567890";
            string specialChars = "!£$%^&*()_-@?#";

            //Commend for user to provide password 
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
                {
                score += 1;
            }

            if (true == Tools.Contains(password, uppercase))
                {
                score += 1;
            }
            if (true == Tools.Contains(password, lowercase))
                {
                score += 1;
            }
            if (true == Tools.Contains(password, digits))
                {
                score += 1;
            }
            if (true == Tools.Contains(password, specialChars))
                {
                score += 1;
            }

            switch (score)
            {
                case 5:
                    Console.WriteLine("Extremely strong");
                    break;
                case 4:
                    Console.WriteLine("Extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Strong");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 1:
                    Console.WriteLine("Weak");
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }

        }
    }
}