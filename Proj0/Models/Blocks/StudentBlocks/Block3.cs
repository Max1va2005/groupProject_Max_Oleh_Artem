using Proj0.Extensions;

namespace Proj0.Model.Blocks
{
    public class Block3 : Block
    {
        protected override void RunFirst(ref int[] array)
        {
            ArrayExtensions.RemoveOddElements(ref array);
        }

        protected override void RunSecond(ref int[][] array)
        {
            int[][] result = new int[(array.GetLength(0)) / 2][];

            for (int i = 1, j = 0; i < array.Length; i += 2, j++)
            {
                result[j] = array[i];
            }

            array = result;
        }
    }
}
