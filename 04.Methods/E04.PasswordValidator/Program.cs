using System;

namespace E04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            IsPasswordValid(password);
        }

        static void IsPasswordValid(string password)
        {
            if (!CheckPasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckPasswordChars(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckPasswordDigitCount(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckPasswordChars(password) && CheckPasswordChars(password) && CheckPasswordDigitCount(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckPasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }

        static bool CheckPasswordDigitCount(string password)
        {
            int digitCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    digitCounter++;
                }
            }

            if (digitCounter >= 2)
            {
                return true;
            }
            return false;
        }

        static bool CheckPasswordChars(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if ((char.IsLetter(password[i]) || char.IsDigit(password[i])) == false)
                {
                    return false;
                }
            }
            return true;
        }
    }

    
}
