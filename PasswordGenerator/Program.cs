using System;

namespace PasswordGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Random rand = new Random();

                    string[] charInPass = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l",
                "z", "x", "c", "v", "b", "n", "m", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ",", ".", ";", "!", "@",
                 "#", "$", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L",
                "Z", "X", "C", "V", "B", "N", "M"};
                    Console.WriteLine("Enter the number of characters in the password: ");

                    int amountCharactersInPassword = int.Parse(Console.ReadLine());
                    if (amountCharactersInPassword > 5000)
                        continue;

                    string password = "";
                    for (int i = 0; i < amountCharactersInPassword; i++)
                    {
                        try
                        {
                            int a = rand.Next(0, 70);
                            password += charInPass[a];
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    Console.WriteLine(password);
                    Console.ReadKey();
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}