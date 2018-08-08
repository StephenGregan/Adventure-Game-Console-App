using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    public class NewGame : Screen
    {
        Input enterName;
        Input enterGender;
        Decision confirmName;
        Decision confirmGender;
        Decision intro;
        Decision travel;
        Decision breakfast;

        public NewGame()
        {
            ScreeensController.Clear();
            
        }

        private void Run()
        {
            Intro();
        }

        private void AddQuestions()
        {
            enterName = new Input("Please enter your name");
            enterGender = new Input("Pleas enter your gender, @Name:");
        }

        private void AddDecisions()
        {
            intro = new Decision("Do you want to go to the bathroom, or downstairs for breakfast?", new List<string>() { "1 Bathroom", "2 Downstairs" });
            travel = new Decision("How do you travel to work?", new List<string>() { "1 Walk", "2 Cycle" });
            breakfast = new Decision("What do you make for breakfast?", new List<string>() { "1 Cereal", "2 Irish breakfast"});
            confirmName = new Decision("Are you happy with this name?", new List<string>() { "1 Yes", "2 No" });
            confirmGender = new Decision("Are you happy with this gander?", new List<string>() { "1 Yes", "2 No" });
        }

        private void Intro()
        {
            ScreeensController.Clear();
            ScreeensController.Write("You wake up in your house.");
            int input = intro.Run();
            if (input == 1)
            {
                Bathroom();
            }
            else
            {
                Kitchen();
            }
        }

        private void Bathroom()
        {
            ScreeensController.Clear();
            ScreeensController.Write("You clean your teeth and go to the shower, but in doing so you are not running late for work!");
            int input = travel.Run();
            if (input == 1)
            {
                Walk();
            }
            else
            {
                Cycle();
            }
        }

        private void Kitchen()
        {
            ScreeensController.Clear();
            ScreeensController.Write("You make your way down to the kitchen to make some food.");
            int input = breakfast.Run();
            if (input == 1)
            {
                ScreeensController.Write("You make a healthy breakfast and find yourself with plenty of food.");
            }
            else
            {
                ScreeensController.Write("You have a massive greasy breakfast that you spend too much time preparing.  You are now late for work!");
            }
            input = travel.Run();
            if (input == 1)
            {
                Walk();
            }
            else
            {
                Cycle();
            }
        }

        private void Walk()
        {
            ScreeensController.Clear();
            ScreeensController.Write("You travel to work by foot.");
            Console.ReadLine();
        }

        private void Cycle()
        {
            ScreeensController.Clear();
            ScreeensController.Write("You travel to work by bike.");
            Console.ReadLine();
        }

        private void EnterName()
        {
            ScreeensController.Clear();
            var charName = enterName.Run();
            int input = confirmName.Run();
            if (input == 1)
            {
                GameController.character.Name = charName;
                EnterGender();
            }
            else
            {
                EnterName();
            }
        }

        private void EnterGender()
        {
            ScreeensController.Clear();
            var charGender = enterGender.Run();
            int input = confirmGender.Run();
            if (input == 1)
            {
                GameController.character.Gender = charGender;
                ScreeensController.Clear();
                ScreeensController.Write("Saved");
                ScreeensController.Write($"Name: { GameController.character.Name }");
                ScreeensController.Write($"Gender: {GameController.character.Gender }");
                GameController.CreateSaveFile();
                Console.Read();
            }
            else
            {
                EnterGender();
            }
        }
    }
}
