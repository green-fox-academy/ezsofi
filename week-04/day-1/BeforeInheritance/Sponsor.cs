﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeInheritance
{
    public class Sponsor : Person
    {
        // FIELDS
        //string Name;
        //int Age;
        //string Gender;
        string Company;
        int HiredStudents;

        // CONSTRUCTORS
        public Sponsor(string name, int age, string gender, string company) 
            : base(name, age, gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Company = company;
            HiredStudents = 0;
        }

        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Company = "Google";
            HiredStudents = 0;
        }

        // METHODS
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }
        public void Hire()
        {
            HiredStudents += 1;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
