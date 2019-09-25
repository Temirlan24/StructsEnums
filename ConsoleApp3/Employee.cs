using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Employee
    {
        public string FullName { get; set; }
        public PositionType Position { get; set; }
        public int Salary { get; set; }
        public DateTime EnterDate { get; set; }
        public void Show()
        {
            Console.WriteLine("ФИО: " + FullName);
            Console.WriteLine("Должность: " + Position);
            Console.WriteLine("Зарплата: " + Salary);
            Console.WriteLine("Дата выхода: " + EnterDate.ToShortDateString());

        }
    }
}
