using Proj0.Controller;
using Proj0.Extensions;
using Proj0.Model;

namespace Proj0
{
    internal class Program
    {
        private const int EXIT_OPTION = 0;
        private const int CREATE_MANUALLY_OPTION = -1;
        private const int CREATE_RANDOMLY_OPTION = 0;
        private const int PRINT_OPTION = 10;

        static void Main(string[] args)
        {
            ITask[] tasks = new ITask[]
            {
                new Task1(),
                new Task2(),
            };

            int[] array1 = null!;
            int[][] array2 = null!;

            while (true)
            {
                var task = ConsoleInputHandler.GetDesiredTask();
                Console.Clear();
                if (task == EXIT_OPTION)
                {
                    break;
                }

                var variant = ConsoleInputHandler.GetDesiredBlock();
                Console.Clear();

                bool useArray1 = (task == 1);

                switch (variant)
                {
                    case CREATE_MANUALLY_OPTION when task == 1:
                        array1 = ArrayExtensions.CreateManually();
                        continue;

                    case CREATE_MANUALLY_OPTION:
                        array2 = ArrayExtensions.CreateManuallyJagged();
                        continue;

                    case CREATE_RANDOMLY_OPTION when task == 1:
                        array1 = ArrayExtensions.CreateRandomly((-100, 100));
                        continue;

                    case CREATE_RANDOMLY_OPTION:
                        array2 = ArrayExtensions.CreateRandomlyJagged((-100, 100));
                        continue;

                    case PRINT_OPTION when task == 1:
                        if (array1 is null)
                        {
                            Console.WriteLine("The array isn't initialized");
                        }
                        else
                        {
                            array1.PrintAll();
                        }

                        Console.ReadKey();
                        continue;

                    case PRINT_OPTION:
                        if (array2 is null)
                        {
                            Console.WriteLine("The array isn't initialized");
                        }
                        else
                        {
                            array2.PrintAll();
                        }
                            
                        Console.ReadKey();
                        continue;
                }

                if (IsInitialized(task, array1, array2))
                {
                    Console.WriteLine("The array isn't initialized");
                    Console.ReadKey();
                    continue;
                }

                tasks[task - 1].ExecuteBlock(variant, ref array1!, ref array2!);
            }
        }

        private static bool IsInitialized(int task, int[] array1, int[][] array2)
        {
            return (task == 1 && array1 is null) || (task == 2 && array2 is null);
        }
    }
}