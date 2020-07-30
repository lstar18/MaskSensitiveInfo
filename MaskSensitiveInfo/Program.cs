using System;
using System.Linq;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a secret here: ");
            var secret = Console.ReadLine();

            var secretInputArray = secret.ToCharArray();

            int BeforeMaskedLetters = secret.Length - 5;
            //Console.WriteLine(BeforeMaskedLetters);
            if (BeforeMaskedLetters >= 0)
            {
                for (int i = 0; i < secretInputArray.Length - 4; i++)
                {
                    secretInputArray[i] = '#';
                }
            }
            else
            {
                for (int i = 0; i < secretInputArray.Length; i++)
                {
                    secretInputArray[i] = '*';
                }
            }
            var finalSecret = string.Join("", secretInputArray.Select(word => word.ToString()).ToArray());

            Console.WriteLine($"Here is your secret word: {finalSecret}.");
        }
    }
}
