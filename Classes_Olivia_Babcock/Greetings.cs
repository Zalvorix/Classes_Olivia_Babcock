using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Olivia_Babcock
{
    class Greetings
    {  
        /// <summary>
        /// Says hello to the user
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler, welcome!");
        }
        /// <summary>
        /// Says the user's presence is welcome
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"Your presence is a welcome addition, {name}.");
        }
            
    }
}
