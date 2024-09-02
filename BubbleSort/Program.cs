namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 6, 5, 3, 1, 8, 7, 2, 4 };
            Console.WriteLine(SortingScript.Sort(numbers));
        }
    }
}