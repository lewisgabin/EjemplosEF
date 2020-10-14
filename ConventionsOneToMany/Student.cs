using System;
using System.Collections.Generic;
using System.Text;

namespace ConventionsOneToMany
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }//la relacion funciona solo con este
    }
}