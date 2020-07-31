﻿using System;
using WorkerBoss.Entities;
using WorkerBoss.Entities.Enums;

namespace WorkerBoss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level worker: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Hours worked: ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.WriteLine("Enter month and year to income MM/YYYY: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month));

        }
    }
}
