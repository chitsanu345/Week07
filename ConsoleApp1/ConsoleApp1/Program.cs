using System;

namespace ConsoleApp1
{
    class Student
    {
        private string name;
        private string id;
        private float gpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public float GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }

}