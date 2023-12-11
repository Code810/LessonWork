using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWork.Domain.Models
{
    public class Group
    {
        public string GroupNo { get;  }
        public static int DefaultGroupNum = 101;
        private int GroupLimit { get; set; }
        private List<Student> Students ;
        public Group(int grouplimit)
        {
            Students = new ();
            GroupLimit = grouplimit;
            GroupNo = $"PB{DefaultGroupNum++}";
        }

        public void AddStudent(Student student)
        {
            
            if (GroupLimit<=0)
            {
                throw new Exception("Yer yoxdur");
            }
            else
            {
                Students.Add(student);

            }
            GroupLimit--;
        }

        public void GetAllStudents()
        {
            if (Students.Count<=0)
            {
                throw new Exception("list bosdur");
            }
            else
            {
                foreach (var item in Students)
                {
                    Console.WriteLine($"Id:{item.Id} Name:{item.Name} Surname:{item.Surname} Point:{item.Point}");
                }
            }
            
        }
        public List<Student> Sort()
        {
            var newlist= Students;
            if (newlist is null)
            {
                throw new Exception("Sort edilmesi ucun liste studen elave edilmelidi");
            }
            else
            {
                newlist.Sort();
                newlist.Reverse();
                return newlist;
            }
        }

    }
}
