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
            // Объявим одномерный массив Data с n-элементами 
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