using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherYouDrive.sources
{
    class UserSettings
    {

        private string mStartPoint;
        private string mMidPointOne;
        private string mEndPoint;

        UserSettings()
        {
            Console.WriteLine("Insert the starting zip code: ");
            mStartPoint = Console.ReadLine();
            Console.WriteLine("Insert the mid point zip code: ");
            mMidPointOne = Console.ReadLine();
            Console.WriteLine("Insert the end point zip code: ");
        }

        class UserStoreDataXML
        {
            UserStoreDataXML()
            {
                // constructor to store information from user.
            }
        }

        class UserPullDataXML
        {
            UserPullDataXML()
            {
                // constructor to pull information from user.
            }
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
