﻿using EmployeeOOP.Classes;
using System;

namespace EmployeeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP APPLICATION");
            Console.WriteLine("---------------");

            //Declarar algunas variables
            int day, month, year;

            Console.Write("Ingresar el día: ");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el mes: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar el año: ");
            year = Convert.ToInt32(Console.ReadLine());

            //Instanciar la clase Date.cs
            Date dateObject = new Date(year, month, day);
            Console.WriteLine(dateObject.ToString()); //23/50/23232
        }
    }
}
