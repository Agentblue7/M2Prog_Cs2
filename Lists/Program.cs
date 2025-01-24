namespace Lists
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
            string[] characters = { "Pac-man", "Samus", "Crash bandicoot", "spyro the dragon", "donkeykong",
                "mario", "luigi", "astro", "solid snake", "master chief", "Kratos", "sonic the hedgehog", "link" };

            List<string> characterslist = new List<string>();
            characterslist.Add("Artyom");
            for (int i = 0; i < characters.Length; i++)
            {
                characterslist.Add(characters[i]);     
                Console.WriteLine(characterslist[i]);
            }
        }
    }
}
