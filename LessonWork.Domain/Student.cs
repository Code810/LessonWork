using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWork.Domain
{
    public class Student:IComparable<Student>
    {
        private static int _id;
        public int Id { get;  }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Point { get; set; }
        public Student(string name, string surname, int point)
        {
            Name = name;
            Surname = surname; 
            Point = point;
            _id++;
            Id = _id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Point:{Point}");
        }

        public int CompareTo(Student? other)
        {
           return other.Point.CompareTo( Point );
        }
        public static bool operator > (Student? a,Student? b)
        {
            return a.Point > b.Point;
        }
        public static bool operator < (Student? a, Student? b)
        {
            return a.Point < b.Point;
        }
    }
}
