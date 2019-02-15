using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;//переменная имя
        public string id;// переменная айди
        public int year;// переменная год обучения 

        public Student(string name, string id)//конструктор с 2 параметрами 
        {
            this.name = name;//чтобы между двумя переменными не было конфликтов 
            this.id = id;
        }
        public Student()// конструктор с 0 параметрами 
        {
            name = Console.ReadLine();// вводим то что надо 
            id = Console.ReadLine();
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintInfo()// метод возвращает данные студента 
        {
            Console.WriteLine(name);// выводим 
            Console.WriteLine(id);
            Console.WriteLine(year);
        }
        public void IncrementOfYear()
        {
            year++;//увеличиваем год обучения на 1
            PrintInfo();// запрашиваем метод ПринтИнфо 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();// инициализируем данные с помощью конструктора :0
            s.IncrementOfYear();// метод возвращает данные
        }
    }
}