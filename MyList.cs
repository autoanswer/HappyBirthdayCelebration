using HappyBirthdayCelebration.NSCongratulation;
using System;
using System.Collections.Generic;

namespace HappyBirthdayCelebration.NSMyList
{
    public partial class MyList
    {
        int Selected = 0;
        int EditIndex = 0;
        double AddedUnixTime = 0;

        List<Congratulation> ListOfCongratulations;
        public MyList()
        {
            this.ListOfCongratulations = new List<Congratulation>()
        {
            new Congratulation() { Description = "Samuel Jackson", UnixTime = 881531800},
            new Congratulation() { Description = "Avery Wilson", UnixTime = 1080521200},
            new Congratulation() { Description = "Steve Angello", UnixTime = 933962400},
        };
        }

        static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }
        static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date - origin;
            return Math.Floor(diff.TotalSeconds);
        }
        public static int CompareUnixTime(Congratulation plan1, Congratulation plan2)
        {
            return plan1.UnixTime.CompareTo(plan2.UnixTime);
        }

        public void SelectedShow() { Console.WriteLine(this.Selected); }
        public void SelectUp()
        {
            if (this.Selected > 0) { this.Selected--; }
        }

        public void SelectDown()
        {
            if (this.Selected < this.ListOfCongratulations.Count - 1) { this.Selected++; }
        }



    }
}