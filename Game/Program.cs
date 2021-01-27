using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1993,
                FirstName = "Kübra",
                LastName = "UÇARSU",
                IdentityNumber = 1111
            });
            Console.WriteLine("Hello World!");
        }
    }
}
