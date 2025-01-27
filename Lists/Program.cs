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

            List<double> reviews = new List<double>() { 9.99, 4.68, 348.97, 12.2 };

            for (int i = 0; i < reviews.Count; i++)
            {
                Console.WriteLine(reviews[i]);
                reviews.Remove(348.97);

            }

            List<Pickup> pickups = new List<Pickup>() {};
            for (int i = 0; i < 10; i++)
            {
                Pickup pickup = new Pickup()
                {
                    x = i,
                    y = 0,
                };
                pickups.Add(pickup);
            }

            //foreach (Pickup pickup in pickups)
            //{
            //if (pickup.x == 4)
            //{
            //    pickups.Remove(pickup);
            //}
            //}

            for (int i = pickups.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(pickups[i]);
                if (pickups[i].x == 4)
                {
                    pickups.RemoveAt(i);
                }

            }
        }

                class Pickup
            {
                internal int x, y;
            }
                class mob
                {
                    internal bool isDead;
                    internal int hp = 10;
                }
            

        }
    }

