using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework
{
    internal class Striker:FootballPlayer
    {
        public int Attaking { get; set; }

        public Striker(string name, int number, int age, int height, int attaking)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
            this.Attaking = attaking;
        }
    }
}
