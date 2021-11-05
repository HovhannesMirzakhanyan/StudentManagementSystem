using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class Teacher
    {
        public Guid id;
        public int age;
        public string name;
        public Student[] students;
        public string _subject;
        public Teacher(string subject)
        {
            _subject = subject;
        }
    }
}
