using System;

namespace Task_32
{
    class Program
    {
        static void Main()
        {
            ArrayBase[] arrayBase = new ArrayBase[3];
            
            arrayBase[0] = new Array1D(4);
            arrayBase[1] = new Array2D(3, 4);
            arrayBase[2] = new JaggedArray(3);
            
            foreach (ArrayBase item in arrayBase)
            {
                item.Output();
                Console.WriteLine($"Average: {item.GetAverage()}");
                Console.WriteLine("");
            }
        }
    }
}