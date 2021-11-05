using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student student1 = new Student("Roman", 15);
            Student[] student2 = new Student[4];
            for(int i=0; i<4; i++)
            {
                student2[i] = new Student($"name-{i}", i);
            }
        }
    }
}
