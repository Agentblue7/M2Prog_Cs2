using System.Runtime.InteropServices;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //we hebben deze gemaakt en het is een progrramma type
            program.Run(); // de programma gaat starten //run   
        }
        internal void Run() 
        {
            Console.WriteLine(vraag1, vraag2, vraag3, vraag4, vraag5);
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
    }
}
