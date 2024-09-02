namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new() { 6, 5, 3, 1, 8, 7, 2, 4 };
            Sort(numbers);
        }

        public static void Sort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1]) { SwapNumbers(numbers, j, j + 1); };
                }
            }
        }

        public static void SwapNumbers(List<int> numbers, int firstIndex, int secondIndex)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }
    }
}