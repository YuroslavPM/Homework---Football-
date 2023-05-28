using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Goalkeeaper : FootballPlayer
    {
        public int Defending { get; set; }

        public Goalkeeaper(string name, int number,int age, int height, int defending)
        {
            Name = name;
            Number = number;    
            Age = age;
            Height = height;
            this.Defending = defending;
        }

    }
}
