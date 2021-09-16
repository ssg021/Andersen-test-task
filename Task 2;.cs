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