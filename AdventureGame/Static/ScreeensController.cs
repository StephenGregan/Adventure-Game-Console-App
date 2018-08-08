using AdventureGame.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Static
{
    class ScreeensController
    {
        public static Screen currentScreen;
        public static Screen previousScreen;
        public static List<string> showScreenText;
        public static void Init()
        {
            showScreenText = new List<string>();
            currentScreen = new MainMenu();
        }

        public static void Write(string screenText)
        {
            showScreenText.Add(screenText);
            Console.WriteLine(screenText);
        }

        public static void Redo()
        {
            showScreenText.ForEach(x => Console.WriteLine(x));
        }

        public static void Clear()
        {
            Console.Clear();
            showScreenText.Clear();
        }



    }
}
