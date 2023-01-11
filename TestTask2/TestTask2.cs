using System.Text;

namespace TT_Saber
{
    class TestTask2
    {
        static void Main(string[] args)
        {
            // пример использования
            var data = new StringBuilder("AAAAAAAAAA BBBB AAAAAAA");
            data = RemoveDups(data);
            Console.WriteLine(data); // "A B A"
        }
        private static StringBuilder RemoveDups(StringBuilder data)
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
            }
            return data;
        }

    }
}
