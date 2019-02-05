using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//вводим число конвертируем ее в тип integer 
            int[] a = new int[n];//создаем массив с элементами типа integer
            int[] b = new int[n];//создаем второй массив 
            string[] s = Console.ReadLine().Split();//создаем массив с элементами тип string и разделяем через пробел
            int cnt = 0;//создаем счетчик 
            bool prime = true;//создаем переменную bool типа
            for(int i = 0; i < n; ++i)//создаем цикл
            {
                prime  = true;
                a[i] = Convert.ToInt32(s[i]);//конвертируем элемент стрингового массива и сохраняем как элемент массива типа integer
                if (a[i] == 1)// если элемент будет равен одному пропускаем 
                    continue;
                for (int j = 2; j < a[i]; ++j)// создаем второй цикл
                {
                    if (a[i] % j == 0)// определяем простое число 
                        prime = false;//если число делится на предыдущие на него числа, начиная от 2, то это число не простое


                }
                if (prime == true)//в противном случае мы записываем простое число  как элемент нового массива 
                {
                    b[cnt] = a[i];
                    cnt++;
                }
            }
            Console.WriteLine(cnt);// выводим количество простых чисел 
            for(int i = 0; i < cnt; ++i)
            {
                Console.Write(b[i] + " ");// выводим простые числа на консоль через пробел 
            }


        }
    }
}
