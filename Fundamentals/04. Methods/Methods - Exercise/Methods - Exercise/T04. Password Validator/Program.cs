using System;


namespace T04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passwordMinLength = 6;
            const int passwordMaxLength = 10;
            const int passwordDigitsMin = 2;

            string password = Console.ReadLine();

            bool isPasswordValid = ValidatePassword(password, passwordMinLength, passwordMaxLength, passwordDigitsMin);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool ValidatePassword(string password, int passwordMinLength, int passwordMaxLength, int passwordDigitsMin)
        {
            bool isPasswordValid = true;

            if (!LengthOfPasword(password, passwordMinLength, passwordMaxLength))
            {
                Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters");
                isPasswordValid = false;    
            }
            if (!MustConsistAlphaNumerical(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isPasswordValid = false;
            }
            if (!MinTwoDigits(password, passwordDigitsMin))
            {
                Console.WriteLine($"Password must have at least {passwordDigitsMin} digits");
                isPasswordValid =false;
            }
            return isPasswordValid;
        }
        static bool LengthOfPasword(string password, int passwordMinLength, int passwordMaxLength)
        {
            if (password.Length >= passwordMinLength && password.Length <= passwordMaxLength)
            {
                return true;
            }
            return false;
        }
        static bool MustConsistAlphaNumerical(string password)
        {
            foreach (char symbol in password)
            {
                if (!Char.IsLetterOrDigit(symbol))
                {
                    return false;
                }   
            }
            return true;
        }
        static bool MinTwoDigits(string password, int minDigits)
        {
            int digitsCount = 0;
            foreach (char  symbol in password)
            {
                if (Char.IsDigit(symbol))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= minDigits;
        }
    }
}
