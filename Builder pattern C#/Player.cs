using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_pattern_C_
{
    internal class Player
    {
        //Test name, level, and bool
        public string Name;
        public int Level;
        public bool joinedGame;

        public Player(PlayerBuilder builder)
        {
            Name = builder.Name;
            Level = 0;  
            joinedGame = false;
        }

        public string CreatePlayerDescription()
        {
            string description = "This is named: " + Name;
            return description; 
        }

    }
}
