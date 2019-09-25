using System;
using System.Collections.Generic;
namespace StudentWorkStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            List<Student> students = new List<Student>();
            Console.WriteLine("Введите количество студентов: ");
            int.TryParse(Console.ReadLine(), out int quantity);
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine("Введите полное имя студента: ");
                student.FullName = Console.ReadLine();
                Console.WriteLine("Введите название группы: ");
                student.GroupName = Console.ReadLine();
                Console.WriteLine("Введите средний балл: ");
                student.AvgMark = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите доход на члена семьи: ");
                student.IncomePerFamilyMember = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите пол: 1.Мужской 2.Женский ");
                int.TryParse(Console.ReadLine(), out int gender);
                if (gender == 1)
                {
                    student.GenderSave = Gender.Male;
                }else if (gender == 2)
                {
                    student.GenderSave = Gender.Female;
                }
                Console.WriteLine("Введите форму обучения: 1.Очный 2.Заочный ");
                int.TryParse(Console.ReadLine(), out int studyForm);
                if (studyForm == 1)
                {
                    student.StudyFormSave = StudyForm.Intramural;
                }
                else if (studyForm == 2)
                {
                    student.StudyFormSave = StudyForm.Correspondence;
                }
                students.Add(student);
            }
            Console.Clear();
            foreach(var element in students)
            {
                element.Show();
            }
            Console.Clear();
            
        }
    }
}
