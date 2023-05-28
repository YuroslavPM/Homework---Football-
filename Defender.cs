using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework
{
    internal class Defender:FootballPlayer
    {
        public Defender(string name, int number, int age, int height, int defending)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
            this.Defending = defending;
        }

        public int Defending { get; set; }


    }
}
