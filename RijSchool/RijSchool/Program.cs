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
        }
    }
}
    
