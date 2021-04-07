using System;

namespace ExceptionHandling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetVideos();
        }

        private static void RunApp()
        {
            try
            {
                Calculator calc = new Calculator();

                var result = calc.Divide(5, 0);

                Console.WriteLine($"Result is {result}");
                //calc.TryParseShowCase();

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("An argument was null");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                // Finally gets executed, no matter what
                Console.WriteLine("Thank you for using our application");
                Console.ReadLine();
            }
        }

        private static void ReadFiles()
        {
            var calc = new Calculator();
            calc.ReadFile();
            Console.WriteLine("Everything is awesome!");

            // Do stuff ...
        }

        private static void GetVideos()
        {
            try
            {
                var api = new YouTubeApi();
                api.GetVideos("Michiel");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}