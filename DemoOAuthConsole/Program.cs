using OAuth;
using System;

namespace DemoOAuthConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPress any cay to start authentication\n\n");
            Console.ReadKey();
        

            WebFormCaller wf = new WebFormCaller();
            var token = wf.GetToken();


            Console.WriteLine(token);
            Console.ReadLine();
        }
    }
}
