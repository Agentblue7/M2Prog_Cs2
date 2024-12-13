namespace Constructors
{
    class Quiz
    {
        internal QuizVraag[] vragen;
        internal QuizVraagAntwoorden[] ingevuldeAntwoorden;

        internal void VoegVraagToeOpIndex(int Index, QuizVraag vraag)
        {
         vragen[Index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int Index, string vraag, string antwoord)
        {
            QuizVraag quizVraag = vragen[Index];
        }

        internal Quiz(int aantalVragen) 
        { 
            vragen = new QuizVraag[aantalVragen];
        }

        internal void StelVraag(int index)
        {
            QuizVraag vraag = vragen[index];
            QuizVraagAntwoorden quizVraagAntwoord = new QuizVraagAntwoorden(vraag);
        }

        
    }
}
