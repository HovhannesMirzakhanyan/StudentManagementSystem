using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class UniversityManager
    {
        Teacher anonimus1 = new Teacher("Math");
        Teacher anonimus2 = new Teacher("Math");
        Teacher anonimus3 = new Teacher("Math");
        Teacher anonimus4 = new Teacher("Math");
        Student[] student2;

        public void Fill()
        {
            student2 = new Student[4];
            for (int i = 0; i < 4; i++)
            {
                student2[i] = new Student($"name-{i}", i, "Math");
            }
           
        }

    }
}
