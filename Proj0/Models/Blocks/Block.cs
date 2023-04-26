using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0.Model.Blocks
{
    public abstract class Block
    {
        public void Run(int task, ref int[] array1, ref int[][] array2)
        {
            if (task == 1)
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
