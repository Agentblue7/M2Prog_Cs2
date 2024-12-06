namespace RijSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal void Run()
        {
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "volkswagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "Volvo"
            };

            Rijleraar rijleraar = new Rijleraar()
            {
                leeftijd = 30,
                naam = "John",
                zzp = false
            };

            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijleraar,

                tijd = 1130
            };

            Student student = new Student()
            {
                LesPakket = LesPakket,
                theorietest = TheorieTest,
                rijtest = RijTest,
                lesUur = lesUur,
            };

            Dag dag = new Dag()
            {
                datum = DateTime,
                lesuren = lesUur
            }
        }
    }
}
    
