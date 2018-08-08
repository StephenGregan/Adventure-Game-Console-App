using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class AdventureGame
    {
        public AdventureGame()
        {
            Start();
        }

        private void Start()
        {
            GameController.Init();
            ScreeensController.Init();
        }
    }
}
