using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    
    internal class Player
    {
        public string name = "sufiyan";
        private int health = 74; 
        // made health private so anywhere if we use health it will throw error as its private 
        // to access it wwill create a method getHealth 

        public int getHealth()
        {
            return health;
        }

        // showing refferance on hover we can see where it is getting used 
        public void setHealth(int h) // methods / functions 
        {
            health = h;
        }
    }
}

// OBJECT ORIENTED PROGRAMMING  
