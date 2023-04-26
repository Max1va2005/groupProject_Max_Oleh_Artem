using Proj0.Model.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0.Model
{
    internal class Task1 : ITask
    {
        private const int CURRENT_TASK = 1;

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
