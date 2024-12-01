namespace ChallengeLab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ChallengeLab_4.2");
            Console.WriteLine("================\n ");
            Dictionary<string, int> count = new Dictionary<string, int>();
            string[] input = ["a", "b", "c", "a", "c", "d", "f", "d"];

            foreach (string s in input)
            {
                if (!count.TryAdd(s, 1))
                {
                    count[s]++;
                }
            }

            //Print out dictionary
            Console.WriteLine();
            foreach (KeyValuePair<string, int> kvp in count)
            { 
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value); 
            }

            Console.WriteLine("\n\nChallengeLab_4.3");
            Console.WriteLine("================\n ");
            Console.WriteLine("Please enter two characters to input as shown in the list below:\n ( )\n [ ]\n { }\n\n");
            Console.WriteLine("Please Enter Character 1: ");
            char character1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nPlease Enter Character 2: ");
            char character2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(IsMatch(character1, character2));

        }

        public static bool IsMatch(char character1, char character2)
        {
            if (character1 == '(' && character2 == ')') return true;
            else if (character1 == '[' && character2 == ']') return true;
            else if (character1 == '{' && character2 == '}') return true;
            else return false;
        }
    }
}
