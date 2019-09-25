using System;
using System.Collections.Generic;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников: ");
            int.TryParse(Console.ReadLine(), out int quantity);
            Employee employees = new Employee();
            List<Employee> managers = new List<Employee>();
            List<Employee> clerks = new List<Employee>();

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Введите полное имя: ");
                employees.FullName = Console.ReadLine();
                Console.WriteLine("Введите должность: 1.Босс  2. Мэнеджэр  3.Клерк ");
                int.TryParse(Console.ReadLine(), out int type);
                switch (type)
                {
                    case 1: employees.Position = PositionType.Boss;break;
                    case 2: employees.Position = PositionType.Manager;break;
                    case 3: employees.Position = PositionType.Clerk;break;
                }
                Console.WriteLine("Введите зарплату сотрудника: ");
                int.TryParse(Console.ReadLine(), out int salary);
                employees.Salary = salary;
                Console.WriteLine("Введите дату выхода: ");
                employees.EnterDate = DateTime.Parse(Console.ReadLine());
                clerks.Add(employees);
            }
            Console.Clear();
            foreach(var employee in clerks)
            {
                employee.Show();
            }
            Console.Clear();
            int avgSum = 0, counter = 0;
            foreach (var employee in clerks)
            {
                if (employee.Position == PositionType.Clerk)
                {
                    avgSum += employee.Salary;
                    counter++;
                }
            }
            avgSum /= counter;
            foreach (var employee in clerks)
            {
                if (employee.Position == PositionType.Manager)
                {
                    if (avgSum < employee.Salary)
                    {
                        employee.Show();
                    }
                }
            }
            foreach (var employee in clerks)
            {
                if (employee.Position == PositionType.Boss)
                {
                    if (avgSum < employee.Salary)
                    {
                        employee.Show();
                    }
                }
            }

        }
    }
}
