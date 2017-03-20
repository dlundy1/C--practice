using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelgateKeypress
{
   // public enum movement { Up, Down, Left, Right, NONE }
    public delegate void movement();
    class Program
    {
        private static int x=20;
        private static int y=20;

        // TBD: You will need to define a data structure to store the association 
        // between the KeyPress and the Action the key should perform

        private static void Main(string[] args)
        {
            // TBD: Set up your control scheme here. It should look something like this:
            //   myControls.Add(ConsoleKey.W, Up)
            //   myControls.Add(ConsoleKey.S, Down)
            // or you can ask the user which keys they want to use
            // etc

            Dictionary<ConsoleKey, movement> myControls;
            myControls = new Dictionary<ConsoleKey, movement>();

            myControls.Add(ConsoleKey.W, Up);
            myControls.Add(ConsoleKey.S, Down);
            myControls.Add(ConsoleKey.D, Right);
            myControls.Add(ConsoleKey.A, Left);

            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("@");

                var key = Console.ReadKey(true);

                int oldX = x;
                int oldY = y;

                // TBD: Replace the following 4 lines by looking up the key press in the data structure
                if (myControls.ContainsKey(key.Key)) {
                    movement method;
                    // Lookup key press, find appropriate move
                    myControls.TryGetValue(key.Key, out method);

                    method();
                    
                }
                else {
                    Console.WriteLine("Invalid Command.");
                }

               /*//and then performing the correct action
                if (key.Key == ConsoleKey.UpArrow) Up();
                if (key.Key == ConsoleKey.DownArrow) Down();
                if (key.Key == ConsoleKey.LeftArrow) Left();
                if (key.Key == ConsoleKey.RightArrow) Right();
                /////////////////////////////////////////////*/

                Console.SetCursorPosition(oldX, oldY);
                Console.Write("+");
            }
        }

        private static void Right()
        {
            x++;
        }

        private static void Left()
        {
            x--;
        }

        private static void Down()
        {
            y++;
        }

        private static void Up()
        {
            y--;
        }
    }
}
