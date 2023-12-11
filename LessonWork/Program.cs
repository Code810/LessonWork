

using LessonWork.Domain;
using LessonWork.Domain.Models;
using System.Xml.Schema;

Group group = new(4);

Student student1 = new("Name1", "Surname1", 55);
Student student2 = new("Name2", "Surname2", 22);
Student student3 = new("Name3", "Surname3", 11);
Student student4 = new("Name4", "Surname4", 44);
Student student5 = new("Name4", "Surname4", 44);
group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);
//group.AddStudent(student5);
group.GetAllStudents();
Console.WriteLine("---------------after sortig method---------------");
foreach (Student student in group.Sort())
{
    student.ShowInfo();
}
Console.WriteLine("---------------Test groupno---------------");
Group group1 = new(5);
Group group2 = new(5);
Console.WriteLine(group.GroupNo);
Console.WriteLine(group1.GroupNo);
Console.WriteLine(group2.GroupNo);
group1.GetAllStudents();