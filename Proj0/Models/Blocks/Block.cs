using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0.Model.Blocks
{
    public abstract class Block
    {
        private const int FIRST_TASK = 1;

        public void Run(int task, ref int[] array1, ref int[][] array2)
        {
            if (task == FIRST_TASK)
            {
                RunFirst(ref array1);
                return;
            }

            RunSecond(ref array2);
        }

        protected abstract void RunFirst(ref int[] array);

        protected abstract void RunSecond(ref int[][] array);
    }
}
