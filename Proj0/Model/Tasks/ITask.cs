using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0.Model
{
    internal interface ITask
    {
        void ExecuteBlock(int block, ref int[] array1, ref int[][] array2);
    }
}
