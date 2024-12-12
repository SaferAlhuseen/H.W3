using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp124
{
    public class Student
    {
       
 public string id;
        public string name;
        public double mark;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentd = new List<Student>();
            Console.WriteLine("Enter the number (5-10) ");
            int SS = int.Parse(Console.ReadLine());
            for (int i = 0; i < SS; i++)
            {
                Console.WriteLine("***************");
                Console.Write("Enter ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter mark: ");
                double mark = double.Parse(Console.ReadLine());
                studentd.Add(new Student { id = id, name = name, mark = mark });
            }
            Console.WriteLine("***\nStudents who passed:");
            foreach (Student student in studentd)
            {
                if (student.mark >= 50)
                {
                    Console.WriteLine(student.name);
                }
            }
            Console.ReadLine();
        }
    }
}

