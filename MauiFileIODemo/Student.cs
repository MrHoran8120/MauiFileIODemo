using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiFileIODemo
{
    public  class Student
    {
       
        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        // empty constructor for serialization
        public Student()
        {

        }
    }
}
