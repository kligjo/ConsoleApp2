using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<double> Grades { get; set; }

        public Student() { }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void AddGrades()
        {
            int listSize = 5;
            List<double> grades = new List<double>(listSize);

            for (int i = 0; i < listSize; i++)
            {
                Console.WriteLine($"Enter Grade {i + 1}");
                grades.Add(Convert.ToDouble(Console.ReadLine()));//kako bi dodale vo lista

            }

            Grades = grades;
        }

        public double CalculateAverage()
        {
            double suma = 0;

            foreach (var ocenka in Grades)
            {
                suma += ocenka;
            }

            return suma / Grades.Count;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student {Name} with age {Age} has an average grade of {CalculateAverage()}");
        }
        public override string ToString()
        {
            return $"Student {Name} with age {Age} has an average grade of {CalculateAverage()}";
        }
    }
}
