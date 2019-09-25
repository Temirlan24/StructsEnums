using System;
using System.Collections.Generic;
using System.Text;

namespace StudentWorkStruct
{
    public class Student
    {
       
        public string FullName { get; set; }
        public string GroupName { get; set; }
        public double AvgMark { get; set; }
        public int IncomePerFamilyMember { get; set; }
        public Gender GenderSave { get; set; }
        public StudyForm StudyFormSave { get; set; }

        public void Show()
        {
            Console.WriteLine("ФИО студента: " + FullName);
            Console.WriteLine("Группа студента: " + GroupName);
            Console.WriteLine("Средний балл студента: " + AvgMark);
            Console.WriteLine("Доход члена семьи студента: " + IncomePerFamilyMember);
            Console.WriteLine("Пол студента: " + GenderSave);
            Console.WriteLine("Форма обучения студента: " + StudyFormSave);
        }
    }
}
