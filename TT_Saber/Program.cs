using System;

namespace TT_Saber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2121321412;
            ShowBinaryRepresentation(a);
            ShowBinaryRepresentation(-a);


            Console.WriteLine();
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(-a, 2));
        }


        private static void ShowBinaryRepresentation(int value)
        {
            int[] binary = new int[32];

            DecToBin(value, binary);
           
            PrintBinaryRepresentation(binary);
        }

        private static void DecToBin(int value, int[] binary)
        {
            short count = 31;
            if (value >= 0)
            {
                for (int i = value; i >= 1; i /= 2)
                {
                    binary[count--] = i % 2;
                }
            }
            else
            {
                for (int i = ~value; i >= 1; i /= 2)
                {
                    binary[count--] = i % 2;
                }
                for (int k = 0; k < binary.Length; k++)
                {
                    binary[k] = binary[k] == 1 ? 0 : 1;
                }

            }
           
        }

        private static void PrintBinaryRepresentation(int[] binary)
        {
            for (int k =0 ; k < binary.Length; k++)
            {
                Console.Write(binary[k]);
            }
            Console.WriteLine();

        }

    }
}
