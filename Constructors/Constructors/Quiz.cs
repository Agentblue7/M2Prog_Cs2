namespace Constructors
{
    class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoorden[] ingevuldeAntwoorden;

        internal Quiz(int aantalVragen) 
        { 
            vragen = new QuizVraag[aantalVragen];
        }
    }
    
}
