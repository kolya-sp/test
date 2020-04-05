using System;
using System.Collections;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 2, 4, 6, 8, 10 };

            IEnumerator ie = numbers.GetEnumerator(); // получаем IEnumerator
            int it = (int)ie.Current;
            Console.WriteLine(it);
            while (ie.MoveNext())   // пока не будет возвращено false
            {
                int item = (int)ie.Current;     // берем элемент на текущей позиции
                Console.WriteLine(item);
            }
            ie.Reset(); // сбрасываем указатель в начало массива
            Console.WriteLine("test chenge gethab");
            Console.Read();
        }
    }
}