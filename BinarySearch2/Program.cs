namespace BinarySearch2
{
    internal class Program
    {
        static public int Main(string[] args)
        {
            int arraySize = int.Parse(args[0]);
            int[] arr = GetArray(arraySize);
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int findElement = int.Parse(Console.ReadLine());
            int index = FindIndex(arr, findElement);
            Console.WriteLine($"Index: {index}");
            if (index == -1) return 1;
            else return 0;
        }

        private static int[] GetArray(int size)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(100);
            }
            return arr;
        }

        private static int FindIndex(int[] arr, int find)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                int middle = (right + left) / 2;
                if (find <= arr[middle])
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            if (arr[left] == find)
            {
                return left;
            }
            else
            {
                return -1;
            }
        }
    }
}