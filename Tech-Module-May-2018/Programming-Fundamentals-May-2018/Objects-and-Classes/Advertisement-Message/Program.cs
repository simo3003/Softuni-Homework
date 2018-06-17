using System;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Message msg = new Message();
                Console.WriteLine(msg.FinishedMessage);
            }
        }
    }

    class Message
    {
        private readonly string[] Phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        private readonly string[] Events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        private readonly string[] Authors =
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Annie",
            "Eva"
        };
        private readonly string[] Cities = 
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };
        public string FinishedMessage;
        private readonly Random rndm = new Random();
        public Message()
        {
            string msgPhrase = Phrases[rndm.Next(0, Phrases.Length)];
            string msgEvents = Events[rndm.Next(0, Events.Length)];
            string msgAuthor = Authors[rndm.Next(0, Authors.Length)];
            string msgCity = Cities[rndm.Next(0, Cities.Length)];
            this.FinishedMessage = $"{msgPhrase} {msgEvents} {msgAuthor} - {msgCity}";
        }
    }
}
