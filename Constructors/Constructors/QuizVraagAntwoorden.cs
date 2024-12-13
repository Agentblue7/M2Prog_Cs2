namespace Constructors
{
        class QuizVraagAntwoorden 
        {
        internal QuizVraag vraag;
        internal bool goed;

        internal QuizVraagAntwoorden(QuizVraag vraag) 
        {
            this.vraag = vraag;
            goed = false;
        }
        }
}
