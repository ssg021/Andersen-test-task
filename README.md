# Andersen-test-task
1)Составить алгоритм: если введенное число больше 7, то вывести “Привет”


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
             int num =
            Convert.ToInt32(Console.ReadLine());
            if (num > 7)
            Console.WriteLine("Привет");    
        }
    }
}




2)Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string  myName = "Вячеслав";
            Console.Write("Введите имя:   ");
             string name = Console.ReadLine(); 
             if (name == myName)  
             Console.WriteLine("Привет,Вячеслав");
             else
             if (name != myName) 
             Console.WriteLine("Нет такого имени");  
        }
    }
}

3) Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Task3 
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // Задаю с клавиатуры число элементов массива
            int n;
            Console.WriteLine("Введите число элементов массива");
            n = Convert.ToInt16(Console.ReadLine());
            // Одномерный массив Data с n-элементами 
            double[] Data = new double[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Введите элемент массива");
                /* Ввод элементов массива с клавиатуры 
                * и заполняю ими массив */
                Data[i] = double.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            // Вывод содержимого массива
            for (i = 0; i < n; i = i + 1)
                Console.Write(Data[i]+" ");

            int v = 0;
            Console.WriteLine("\nКратные трем:");
            for(i=0;i<n;i++)
                if (Convert.ToInt32(Data[i]) % 3 == 0) { Console.WriteLine("Data[" + i + "]=" + Data[i]); v++; }
            Console.WriteLine("Всего:" + v);
            Console.ReadKey();
        }
    }
}

4)Дана скобочная последовательность: [((())()(())]]
- Нет, последовательность неправильна. 
- Необходимо добавить [ и ), чтоб последовательность стала правильной.
