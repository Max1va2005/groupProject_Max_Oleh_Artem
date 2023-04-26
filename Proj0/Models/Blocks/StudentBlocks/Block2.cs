namespace Proj0.Model.Blocks
{
    public class Block2 : Block
    {
        protected override void RunFirst(ref int[] array)
        {
            int[] res = InsertionMaxAndMin(array); Console.WriteLine("Вигляд массиву пiсля вставки в початок масиву мiнiмуму з усiх значень масиву, а в кiнець — максимум");
            OutputMass(res);
        }
        protected override void RunSecond(ref int[][] array)
        {
            PrintArray(array);
            Console.WriteLine("Вигляд массиву пiсля знищення  рядкiв, в яких знаходяться мiнiмальнi елементи матрицi"); RemoveRows(array);
        }
        static int[] InsertionMaxAndMin(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int[] newArr = new int[arr.Length + 2];
            newArr[0] = min; newArr[newArr.Length - 1] = max;
            for (int i = 1; i < newArr.Length - 1; i++)
            {
                newArr[i] = arr[i - 1];
            }
            return newArr;
        }
        static void OutputMass(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static int FindMin(int[][] arr)
        {
            int min = arr[0][0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                    {
                        min = arr[i][j];
                    }
                }
            }
            return min;
        }
        static void RemoveRows(int[][] jaggedArray)
        {
            int[][] newMatrix = new int[jaggedArray.Length][];
            int newRow = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                bool hasMin = false;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == FindMin(jaggedArray))
                    {
                        hasMin = true; break;
                    }
                }
                if (!hasMin)
                {
                    newMatrix[newRow] = jaggedArray[i];
                    newRow++;
                }
            }
            int[][] result = new int[newRow][];
            for (int i = 0; i < newRow; i++)
            {
                result[i] = newMatrix[i];
            }
            Console.WriteLine("Матриця після видалення рядків із мінімальним елементом має вигляд :");
            PrintArray(result);
        }
        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
