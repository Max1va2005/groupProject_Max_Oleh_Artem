namespace Proj0.Extensions
{
    public static class ArrayExtensions
    {
        public static int[] CreateRandomly((int, int) boundaries)
        {
            Console.WriteLine("Enter the size: ");
            int.TryParse(Console.ReadLine(), out int size);

            if (size < 0)
                throw new ArgumentOutOfRangeException("Invalid size");

            int[] result = new int[size];

            Random random = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(boundaries.Item1, boundaries.Item2 + 1);
            }

            return result;
        }

        public static int[][] CreateRandomlyJagged((int, int) boundaries)
        {
            (int, int) size = GetJaggedArraySize();

            int[][] result = new int[size.Item1][];
            Random random = new Random();

            for (int i = 0; i < result.Length; i++)
            {
                int[] array1 = new int[size.Item2];

                for (int j = 0; j < array1.Length; j++)
                {
                    array1[j] = random.Next(boundaries.Item1, boundaries.Item2 + 1);
                }

                result[i] = array1;
            }

            return result;
        }

        public static int[] CreateManually()
        {
            Console.WriteLine("Enter elements of the array using \"space\" to separate them");

            string[] line = Console.ReadLine().Trim().Split();

            int[] result = new int[line.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(line[i]);
            }

            return result;
        }

        public static int[][] CreateManuallyJagged()
        {
            Console.WriteLine("Enter number of rows");
            int rows = int.Parse(Console.ReadLine());

            int[][] result = new int[rows][];

            Console.WriteLine("Enter elements of the rows using \"space\" to separate them");

            for (int i = 0; i < result.Length; i++)
            {
                string[] line = Console.ReadLine().Trim().Split();
                result[i] = new int[line.Length];

                for (int j = 0; j < result.Length; j++)
                {
                    result[i][j] = int.Parse(line[j]);
                }
            }

            return result;
        }

        public static void RemoveAtEvenIndexes<T>(ref T[] array)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                array = array.RemoveAt(i);
                i--;
            }
        }

        public static T[] RemoveAt<T>(this T[] source, int index)
        {
            List<T> list = source.ToList();

            list.RemoveAt(index);

            return list.ToArray();
        }

        public static void PrintAll<T>(this T[] values, Action<T> printer = null!)
        {
            if (printer is not null)
            {
                foreach (var item in values)
                {
                    printer.Invoke(item);
                }

                return;
            }

            foreach (var item in values)
            {
                Console.Write(item + " ");
            }
        }

        public static void PrintAll<T>(this T[][] values)
        {
            foreach (var array in values)
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }

        private static (int, int) GetJaggedArraySize()
        {
            Console.WriteLine("Enter the rows: ");
            int.TryParse(Console.ReadLine(), out int rows);

            Console.WriteLine("Enter the columns: ");
            int.TryParse(Console.ReadLine(), out int columns);

            if (rows < 0 || columns < 0)
                throw new ArgumentOutOfRangeException("Invalid size of a jagged array");

            return (rows, columns);
        }
    }
}
