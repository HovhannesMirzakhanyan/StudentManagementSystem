using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Student
    {
        public Student()
        {
            _id = Guid.NewGuid();
           
        }
        public Student(string name, int age, string subject)
        {
            _id = Guid.NewGuid();
            _name = name;
            _age = age;
            _subject = subject;

        }
        public Guid _id;
        public int _age;
        public string _name;
        public Teacher _teacher;
        public string _subject;
    }
}
