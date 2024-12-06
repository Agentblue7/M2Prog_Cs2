using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Constructors
{
    internal partial class Program
    {
        private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("Hoe lang is een chinees", "ja");
            Quiz quiz = new Quiz(10);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
    }
    
}
