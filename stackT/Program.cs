using System;
namespace stackT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack <string> beaches = new Stack<string>();
            beaches.Push("Hazarot");
            beaches.Push("Sunset Shores");
            beaches.Push("Empire");
            beaches.Push("Esch Road");
            beaches.Push("Peterson");

            Console.WriteLine("How many beaches would you like to add?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(" Beaches name: ");
                beaches.Push(Console.ReadLine());
            }
            Console.WriteLine("Would you like to look a beach? Yes or No>");
            string answer = Console.ReadLine();
            while(answer == "yes")
            {
                Console.WriteLine("Enter the name of the beach you would like to search for");
                string beachName = Console.ReadLine();
                if (beaches.Contains(beachName))
                {
                    Console.WriteLine("That beach is part of the group.");
                }
                else
                {
                    Console.WriteLine("Would you like to look for another beach. Yes or No");
                    Console.ReadLine();
                }
                Console.WriteLine($"Here is your {beaches.Count()} beaches");
                foreach (var b in beaches)
                {
                    Console.WriteLine(b);
                }
                string firstBea = beaches.Peek();
                Console.WriteLine($"Would you like to remove {firstBea} from the end of the stack? Yes or No?");
                answer = Console.ReadLine();
                while (answer == "yes")
                {
                    beaches.Pop();
                    firstBea = beaches.Peek();
                    Console.WriteLine($"Would you like to remove {firstBea} from the end of the stack? Yes or No? ");
                    answer = Console.ReadLine();
                }
                if (beaches.Peek() == null)
                    Console.WriteLine("The stack is empty");
                else
                    Console.WriteLine($"You have {beaches.Count} left in the stack");
            }
        }
    }
}
