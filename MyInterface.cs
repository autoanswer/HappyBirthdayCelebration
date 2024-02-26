using HappyBirthdayCelebration.NSMyList;
using System;

namespace HappyBirthdayCelebration.NSMyInteface
{
    public class MyInterface
    {
        public MyInterface()
        {

        }

        public void MainScreen(MyList MyListObj)
        {
            Console.Clear();
            Console.WriteLine("Happy Birthday Celebrations");
            Console.WriteLine();
            MyListObj.Show();

            Console.WriteLine();
            Console.WriteLine("Press Cursor Key \"UP\" or \"DOWN\" to Select Note");
            Console.WriteLine("Press \"A\" to Add Note");
            Console.WriteLine("Press \"R\" to Remove Note");
            Console.WriteLine("Press \"E\" to Edit Note");
            Console.WriteLine();
            Console.WriteLine("Press \"X\" to Exit");

            Console.WriteLine();
            Console.WriteLine();
        }

        public void MyReadKey(MyList MyListObj)
        {
            while (true)
            {
                ConsoleKeyInfo Key = Console.ReadKey(true);

                if (Key.Key == ConsoleKey.UpArrow)
                {
                    MyListObj.SelectUp();
                    MainScreen(MyListObj);
                }

                if (Key.Key == ConsoleKey.DownArrow)
                {
                    MyListObj.SelectDown();
                    MainScreen(MyListObj);
                }

                if (Key.Key == ConsoleKey.A)
                {
                    MyListObj.Add();
                    MainScreen(MyListObj);
                }

                if (Key.Key == ConsoleKey.R)
                {
                    MyListObj.Remove();
                    MainScreen(MyListObj);
                }

                if (Key.Key == ConsoleKey.E)
                {
                    MyListObj.Edit();
                    MainScreen(MyListObj);
                }

                if (Key.Key == ConsoleKey.X)
                {
                    Console.Write("Exit Program!");
                    break;
                }
            }
        }
    }
}