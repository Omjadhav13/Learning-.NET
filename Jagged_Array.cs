namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of Batches: ");
            int rows = int.Parse(Console.ReadLine()!);

            int[][] jagged = new int [rows][];

            for(int i =0; i<rows; i++)
            {
                Console.Write($"Enter number of element in students {i + 1}: ");
                int cols = int.Parse(Console.ReadLine()!);

                jagged[i] = new int[cols];

                Console.Write($"Enter {cols} elements for marks {i + 1}:");
                for (int j = 0; j < cols; j++)
                {
                    jagged[i][j] = int.Parse(Console.ReadLine()!);
                }

            }

            Console.WriteLine("\nJagged Array Elements:");
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
