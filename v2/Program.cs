namespace vowelcounter
{
    class vowel
    {
        static void Main()
        {
            int total = 0;
            var vowel = new List<char> {'a', 'e', 'i', 'o', 'u'}; 
            Console.WriteLine("Type something");
            var usertext = Console.ReadLine();

            for (int i = 0; i < usertext.Length; i++)
            {
                if (vowel.Contains(usertext[i]))
                {
                    total++;
                }
            }
            Console.WriteLine("Vowels= {0}",total);
            Console.ReadLine();
        }
    }
}