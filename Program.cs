﻿using HappyBirthdayCelebration.NSMyInteface;
using HappyBirthdayCelebration.NSMyList;


namespace HappyBirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {

            MyInterface MI = new MyInterface();
            MyList ML = new MyList();

            MI.MainScreen(ML);
            MI.MyReadKey(ML);





            //TimeStamp TS = new TimeStamp(2000, 02, 13, 01, 62, 63);

        }



    }
}
