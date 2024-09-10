using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern_C_
{
    internal class PlayerBuilder
    {
        //String variable to hold player name
        public string Name;

        //User defined constructor
        public PlayerBuilder() {
            Name = "Player_2";
        }  


        public Player BuildPlayer()
        {
            return new Player(this);
        }
    }
}
