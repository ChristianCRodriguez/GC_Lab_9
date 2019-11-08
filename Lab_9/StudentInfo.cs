using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class StudentInfo
    {
        public string Name;
        public string Hometown;
        public string Food;
        public string Color;
        
        //default constructor
        public StudentInfo() {}

        //overloaded constructor
        public StudentInfo(string name)
        {
            Name = name;
        }
        public StudentInfo(string name, string hometown)
        {
            Name = name;
            Hometown = hometown;
        }
        public StudentInfo(string name, string hometown, string food)
        {
            Name = name;
            Hometown = hometown;
            Food = food;
        }
        public StudentInfo(string name, string food, string hometown, string color)
        {
            Name = name;
            Hometown = hometown;
            Food = food;
            Color = color;
        }

    }
}
