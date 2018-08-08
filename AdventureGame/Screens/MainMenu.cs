using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class MainMenu : Screen
    {
        Decision mainMenu;
        public MainMenu()
        {
            ScreeensController.Clear();
            AddDecisions();
            Run();
        }

        private void Run()
        {
            ScreeensController.Write("Adventure Game...Enjoy!");
            ShowMenuOptions();
        }

        private void AddDecisions()
        {
            mainMenu = new Decision("What would you like to do?", new List<string>() { "1 New Game", "2 Load Game", "3 Exit" });
        }

        private void ShowMenuOptions()
        {
            int input = mainMenu.Run();
            Navigate(input);
        }

        private void Navigate(int input)
        {
            if (input == 1) ScreeensController.currentScreen = new NewGame();
            else if (input == 2) ScreeensController.currentScreen = new LoadGame();
            else if (input == 3) Environment.Exit(0);
        }
    }
}
