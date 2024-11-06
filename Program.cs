namespace Assignment_1_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        //Assignment 1_3_2
        //Write a console application in C# to explore different ways in which array is declared and initialized and explore different properties and methods of Array class. Length and Sorted and Unsorted
        {
            string[] helicopters = { "Black Hawk", "Apache", "Chinook", "Kiowa" };
            Console.WriteLine(helicopters[0]);
            Console.WriteLine(helicopters.Length);

            Console.WriteLine();
            string[] states = { "Virginia", "Florida", "Hawaii", "Texas", "Alabama" };
            Console.WriteLine(states[3]);

            Console.WriteLine();
            Array.Sort(states);
            foreach (string state in states)
            {
            Console.WriteLine(state);
            }

        }
    }
}
