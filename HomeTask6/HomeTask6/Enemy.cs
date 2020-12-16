using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class Enemy
    {
        public char Enemys { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }

        public Enemy(char enemys, int xPos, int yPos)
        {
            Enemys = enemys;
            this.xPos = xPos;
            this.yPos = yPos;
        }
    }
}
