using System;


namespace ConsoleApp1
{
    class Program
    {

        static int length = 0;
        static private void Main(string[] args)
        {
            MainFunction();
        }

        private static void MainFunction()
        {
            Console.WriteLine("Input Token Length");

            if (int.TryParse(Console.ReadLine(), out length)) { } else { Console.Clear(); MainFunction(); }

            Random rnd = new Random();

            var chars = new int[length];

            for (int i = 0; i < length; i++)
            {
                if (rnd.Next(0, 10) >= 5) // Numbers
                {
                    chars[i] = rnd.Next(48, 57);
                }
                else // Letters
                {
                    if (rnd.Next(0, 10) >= 5) // Uppercase
                    {
                        chars[i] = rnd.Next(65, 90);
                    }
                    else // Lowercase
                    {
                        chars[i] = rnd.Next(97, 122);
                    }
                }
            }

            string token = string.Empty;

            for (int i = 0; i < chars.Length; i++)
            {
                token += (char)chars[i];
            }

            Console.WriteLine("Your Token :: " + token);
            Console.ReadLine();
            MainFunction();
        }




























































        //static int length = 0;

        //[STAThread]
        //static void Main(string[] args)
        //{
        //    MainFunction();
        //}

        //static private void MainFunction()
        //{
        //    Console.WriteLine("Choose Token Digit Length");

        //    // if not able to parse then reget input
        //    if (int.TryParse(Console.ReadLine(), out length)) { } else { Console.Clear(); MainFunction(); }


        //    // a random value generator
        //    Random rnd = new Random();

        //    // ints that make up the random token
        //    var chars = new int[length];


        //    // for however long user chose
        //    for (int i = 0; i < length; i++)
        //    {
        //        // Numbers
        //        if (rnd.Next(0,10) >= 5)
        //        {
        //            chars[i] = rnd.Next(48, 57);
        //        }
        //        else // Letters
        //        {

        //            // Uppercase
        //            if (rnd.Next(0, 10) >= 5)
        //            {
        //                chars[i] = rnd.Next(65, 90);
        //            }
        //            else // Lowercase
        //            {
        //                chars[i] = rnd.Next(97, 122);
        //            }
        //        }
        //    }
        //    // Output Token
        //    string token = string.Empty;

        //    // Add random values to output toekn
        //    for (int i = 0; i < chars.Length; i++)
        //    {
        //        token += (char)chars[i];
        //    }

        //    Console.WriteLine("Your Token :: " + token);
        //    Console.WriteLine("Press enter to generate another token");
        //    Console.Read();
        //    MainFunction();
        //}
    }
}
