using Proj0.Model.Blocks;

namespace Proj0.Model
{
    internal class Task2 : ITask
    {
        private const int CURRENT_TASK = 2;

        private Block[] _blocks = new Block[]
        {
            new Block1(),
            new Block2(),
            new Block3()
        };

        public void ExecuteBlock(int block, ref int[] array1, ref int[][] array2)
        {
            _blocks[block - 1].Run(CURRENT_TASK, ref array1, ref array2);
        }
    }
}
