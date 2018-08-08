using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    class Input
    {
        private string _question;
        private Regex charName = new Regex(@"Name");

        public Input(string question)
        {
            _question = question;
        }

        public string Run()
        {
            Display();
            return Console.ReadLine();
        }

        private void Display()
        {
            UpdateQuestion();
            ScreeensController.Write(_question);
        }

        private void UpdateQuestion()
        {
            _question = charName.Replace(_question, GameController.character.Name);
        }
    }
}
