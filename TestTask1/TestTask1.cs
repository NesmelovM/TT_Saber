namespace TT_Saber
{
    class TestTask1
    {
        static void Main(string[] args)
        {
            //  Несмелов Марат Олегович, 11.01.2023, ушло около 6 часов
            //  в основном сложность составило размышление об использовании
            //  коллекции (стек), скорее всего назвали бы его библиотечным классом, 
            //  и решение с отрицательными числами


            int numbercheck = -156;
            ShowBinaryRepresentation(numbercheck);
            ShowBinaryRepresentation(-numbercheck);


            Console.WriteLine();
            Console.WriteLine(Convert.ToString(numbercheck, 2));
            Console.WriteLine(Convert.ToString(-numbercheck, 2));
        }


        private static void ShowBinaryRepresentation(int value)
        {
            int[] binary = DecToBin(value);

            PrintBinaryRepresentation(binary);
        }

        private static int[] DecToBin(int value)
        {
            // Решил не мучиться с увеличением и выделением памяти и принял за факт, что все числа наши будут 32 разрядными
            int[] binary = new int[32];

            if (value >= 0)
            {
                GetRemainders(value, binary);
            }
            else
            {
                GetRemainders(~value, binary);              //Вот тут немного схитрил, по идеи должен
                for (int k = 0; k < binary.Length; k++)     //добавлять еденицу, но не пришлось этого делать, удивился, но работает.
                {                                           //был вариант работы с модулем и дополнением числа, но оставлю так.
                    binary[k] = binary[k] == 1 ? 0 : 1;
                }

            }
            return binary;

        }

        private static void GetRemainders(int value, int[] binary)
        {
            int count = binary.Length - 1;

            for (int i = value; i >= 1; i /= 2)
            {
                binary[count--] = i % 2;
            }
        }


        private static void PrintBinaryRepresentation(int[] binary)
        {
            bool oneFinded = false;
            for (int k = 0; k < binary.Length; k++)
            {
                if (binary[k] == 0 && !oneFinded)
                {
                    continue;
                }
                if (!oneFinded && binary[k] == 1)
                {
                    oneFinded = true;
                }
                Console.Write(binary[k]);
            }
            Console.WriteLine();

        }

    }
}