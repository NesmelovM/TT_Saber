﻿using System.Text;

namespace TT_Saber
{
    class TestTask2
    {
        static void Main(string[] args)
        {
            //  Несмелов Марат Олегович, 11.01.2023, ушло около 1.5 часов
            //  без вложенного цикла обойтись не смог, учитывая, что строчка
            //  может быть с разным количеством символов А или В например.
            //  Пришел либо к рукерсии, либо к зацикливанию цикла с проверкой
            //  выполненности требуемой задачи


            var data = new StringBuilder("AAAAAAAA BBBB AAAAAAA FFFF S");
            RemoveDups(data);
            Console.WriteLine(data); // "A B A"
        }
        private static void RemoveDups(StringBuilder data)
        {
            bool isRemovedRepeat = false;

            while (!isRemovedRepeat)
            {

                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] == data[i + 1])
                    {
                        data.Remove(i, 1);
                        isRemovedRepeat = false;
                    }
                    else
                    {
                        isRemovedRepeat = true;
                    }
                }
                for (int i = 0; i < data.Length - 1; i++) //понимаю, что не изящно, но я вышел за пределы указанного мною времени.
                {                                         //подумаю еще, но пока так.
                    if (data[i] == data[i + 1])
                    {
                        isRemovedRepeat = false;
                    }
                }
            }

        }
    }
}
