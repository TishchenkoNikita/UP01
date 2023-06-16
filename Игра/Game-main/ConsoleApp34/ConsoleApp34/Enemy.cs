using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    public class Enemy
    {
        public Enemy(double health, double damage, int level, int experience)
        {
            Health = health;
            Damage = damage;
            Level = level;
            Experience = experience;
        }

        public double Health { get; set; }
        public double Damage { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }


    }
}

