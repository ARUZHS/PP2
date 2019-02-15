using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\aruzh\source\repos\Week2\Task1\Task1\input.txt");// считываем стринг через инпут файл
            for (int i = 0, j = text.Length - 1; i < j; i++, j--)//цикл создан чтоб узнать является ли стринг палидромом
            {
                if (text[i] != text[j])//если эти буквы будут не одинаковыми (то есть допустим первая и посл буква и тд)
                {
                    Console.WriteLine("No");//выводим нет
                    return;//завершаем выполнение метода
                }
            }
            Console.WriteLine("Yes");//если же те буквы равны тогда выводим да
        }
    }
}
