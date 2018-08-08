using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Classes
{
    public class Character
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Character()
        {
            Name = "Stephen";
            Gender = "Male";
        }
    }
}
