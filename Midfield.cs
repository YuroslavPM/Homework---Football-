using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Midfield:FootballPlayer
    {
        public Midfield(string name, int number, int age, int height, int attaking)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
            this.Attaking = attaking;
        }

        public int Attaking { get; set; }


    }
}
