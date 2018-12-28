using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherYouDrive.sources;
using Microsoft.Extensions.Http;


namespace WeatherYouDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSettings gUserSettings = new UserSettings();
            LocationAPI gLocationData = new LocationAPI(ref gUserSettings);

            //Location API (distance)
            //Distance API
            //Location Objects
            //Weather API
            //Weather Objects
            //FindBestTimes
            //PrintBestTimes

        }

        //static void FindBestTimes()
        //{
            // find the best times to drive using algorithims
        //}

        //static void PrintBestTimes()
        //{;
            // print the best times to drive.
        //}
    }
}
