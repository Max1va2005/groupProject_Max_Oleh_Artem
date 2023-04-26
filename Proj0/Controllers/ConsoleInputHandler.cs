using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj0.Controller
{
    public static class ConsoleInputHandler
    {
        private static int[] _possibleTasks = new int[] { 0, 1, 2 };
        private static int[] _possibleVariants = new int[] { -1, 0, 1, 2, 3, 10 };

        public static int GetDesiredTask()
        {
            Console.WriteLine("Enter the task: \n" +
                "0. Exit\n" +
                "1. Task 1\n" +
                "2. Task 2");
            int.TryParse(Console.ReadLine(), out int task);

            if (!_possibleTasks.Contains(task))
                throw new ArgumentOutOfRangeException(nameof(task));

            return task;
        }

        public static int GetDesiredBlock()
        {
            Console.WriteLine("Enter the variant: \n" +
                "-1. Enter the array manually\n" +
                "0. Enter the array randomly\n" +
                "1. Execute Oleh's block\n" +
                "2. Execute Maksim's block\n" +
                "3. Execute Artem's block\n" +
                "10. Print current state");

            int.TryParse(Console.ReadLine(), out int option);

            if (!_possibleVariants.Contains(option))
                throw new ArgumentOutOfRangeException(nameof(option));

            return option;
        }
    }
}
