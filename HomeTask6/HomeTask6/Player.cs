using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6
{
    class Player
    {
        public char Players { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }

        public Player(char players, int xPos, int yPos)
        {
            Players = players;
            this.xPos = xPos;
            this.yPos = yPos;
        }

       
    }
}
