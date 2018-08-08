using AdventureGame.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame.Screens
{
    class Decision
    {
        public List<string> Options { get; }
        public List<string> ValidResponse { get; }
        public List<string> Question { get; }

        public Decision(string question, List<string> options)
        {
            Question = Question;
            Options = options;
            ValidResponse = new List<string>();
            Options.ForEach(x =>
            {
            ValidResponse.Add(x[0].ToString());
            });
        }

        public int Run()
        {
            Display();
            return HandleInput();

        }

        private void Display()
        {
            Console.WriteLine(Question);
            Options.ForEach(x => Console.WriteLine(x));
        }

        private int HandleInput()
        {
            int ret = 0;
            bool success = false;
            while (success == false)
            {
                var result = Console.ReadLine();
                ValidResponse.ForEach(x =>
                {
                    if (x == result)
                    {
                        ret = Convert.ToInt16(x);
                        success = true;
                    };
                });
                if (!success)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Entry.  Please try again.");
                    ScreeensController.Redo();
                    Display();
                }
            }
            return ret;
        }


    }
}
