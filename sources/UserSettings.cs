using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherYouDrive.sources
{
    public class UserSettings
    {

        private string mStartPoint;
        private string mMidPointOne;
        private string mEndPoint;

        public UserSettings()
        {
            Console.WriteLine("Insert the starting zip code: ");
            mStartPoint = Console.ReadLine(); 

            Console.WriteLine("Insert the mid point zip code: ");
            mMidPointOne = Console.ReadLine();

            Console.WriteLine("Insert the end point zip code: ");
            mEndPoint = Console.ReadLine();

        }

        

        public string StartPoint
        {
            get
            {
                return mStartPoint;
            }
            set
            {
                mStartPoint = value;
            }
        }

        public string MidPointOne
        {
            get
            {
                return mMidPointOne;
            }
            set
            {
                mMidPointOne = value;
            }
        }

        public string EndPoint
        {
            get
            {
                return mEndPoint;
            }
            set
            {
                mEndPoint = value;
            }
        }
    }
}
