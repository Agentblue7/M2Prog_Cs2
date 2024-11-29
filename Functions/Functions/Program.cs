using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called puckman in Japan"
        };

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }

        internal string GetRandomVraag()
        {
            //gebruik random 
            int random = 1;
            return...;
        }
        static void Main(string[] args)
        {
            Program program = new Program(); //we hebben deze gemaakt en het is een progrramma type
            program.Run(); // de programma gaat starten //run   
        }
        internal void Run() 
        {
            Console.WriteLine(vraag1())
            Console.WriteLine(vraag2());
            Console.WriteLine(vraag3());
            Console.WriteLine(vraag4());
            Console.WriteLine(vraag5());   
            string vraag0 = GetVraag(0);
        }

        internal void vraag1()
        {
            Console.WriteLine("How long do you think you´d survive in a zombie apocalypse?" );
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag2()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag3()
        {
            Console.WriteLine("Who is your favorite cs player");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag4()
        {
            Console.WriteLine("smash or pass? Yae Miko.");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void vraag5()
        {
            Console.WriteLine("Those who know?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal string vraag6()
        {
            Console.WriteLine("How long is your cock");
                string antwoord = Console.ReadLine();

            return antwoord;

            string antwoord6 = Vraag6();
            Console.WriteLine(antwoord6);
        }
    }
}
