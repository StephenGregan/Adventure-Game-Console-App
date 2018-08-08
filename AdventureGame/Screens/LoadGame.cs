using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class LoadGame : Screen
    {
        public LoadGame()
        {
            AddDecisions();
            Run();
        }

        private void Run()
        {

        }

        private void AddDecisions()
        {
            ValidOptions = new List<string>();
            ValidOptions.Add("1");
        }
    }
}
