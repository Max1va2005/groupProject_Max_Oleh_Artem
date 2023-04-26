using System.Runtime.InteropServices;
using Proj0.Extensions;

namespace Proj0.Model.Blocks
{
    public class Block1 : Block
    {
        protected override void RunFirst(ref int[] array)
        {
            ArrayExtensions.RemoveAtEvenIndexes(ref array);
        }

        protected override void RunSecond(ref int[][] array)
        {
            ReadIndexOfRowsToBeDeleted(out int rightIndex, out int leftIndex);

            if (IsInRange(array, rightIndex, leftIndex))
            {
                DeleteLinesOfArray(ref array, rightIndex, leftIndex);
            }
        }

        private static void ReadIndexOfRowsToBeDeleted(out int rightIndex, out int leftIndex)
        {
            Console.WriteLine("Видалити всі рядки з:");
            rightIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("по:");
            leftIndex = int.Parse(Console.ReadLine());

            if (rightIndex > leftIndex)
            {
                int temp = rightIndex;
                rightIndex = leftIndex;
                leftIndex = temp;
            }
        }

        static bool IsInRange(int[][] array, int rightIndex, int leftIndex)
        {
            if (array.Length > rightIndex && array.Length > leftIndex && 0 <= rightIndex && 0 <= leftIndex)
            {
                return true;
            }

            Console.WriteLine("Заданий проміжок не входить в діапазон значень");
            return false;
        }

        static void DeleteLinesOfArray(ref int[][] array, int rightIndex, int leftIndex)
        {
            for (int i = rightIndex - 1; i < array.Length - (leftIndex - rightIndex + 1); i++)
            {
                array[i] = array[i + (leftIndex - rightIndex + 1)];
            }

            Array.Resize(ref array, array.Length - (leftIndex - rightIndex + 1));
        }
    }
}

