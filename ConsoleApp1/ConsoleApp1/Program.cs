﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student();
            su.Name = "Student Name";
            su.ID = "12345678";
            su.GPA = 3.5f;
            Console.WriteLine("Student name : " + su.Name);
            Console.WriteLine("Student ID   : " + su.ID);
            Console.WriteLine("Student GPA  : " + su.GPA);
            Console.ReadLine();
        }
    }
    class Student
    {
        private string Name;
        private string ID;
        private float GPA;
    }

}