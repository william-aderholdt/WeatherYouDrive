using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.HttpClient;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace WeatherYouDrive.sources
{
    public class LocationAPI
    {
        private string mApiKeyBing;
        private string mStartPointLocUrl;
        private string mMidPointOneLocUrl;
        private string mEndPointLocUrl;
        private static string mStartPointLoc;
        private static string mMidPointOneLoc;
        private static string mEndPointLoc;

        public LocationAPI(ref UserSettings gUserSettings)
        { 
            mApiKeyBing = "kQimg4b1WA2lgiHhYivs~d5obi3zY-teGtJRkVwuvVw ~At-spLj2t7hmNApxy5V4xtqEgMeibgrx2kpDge-Ey3KnF0czF6Gws8xdKErJKqa9";

            mStartPointLocUrl = "http://dev.virtualearth.net/REST/v1/Locations?postalCode=" + gUserSettings.StartPoint + "&key=" + mApiKeyBing;
            mMidPointOneLocUrl = "http://dev.virtualearth.net/REST/v1/Locations?postalCode=" + gUserSettings.MidPointOne + "&key=" + mApiKeyBing;
            mEndPointLocUrl = "http://dev.virtualearth.net/REST/v1/Locations?postalCode=" + gUserSettings.MidPointOne + "&key=" + mApiKeyBing;

            LoadStartPointLocation(mStartPointLocUrl);
            LoadMidPointOneLocation(mMidPointOneLocUrl);
            LoadEndPointLocation(mEndPointLocUrl);
        }

        private static async Task<string> LoadStartPointLocation(string mStartPointLocUrl)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(mStartPointLocUrl);

                HttpResponseMessage response = await client.GetAsync(mStartPointLocUrl);

                if (response.IsSuccessStatusCode)
                {
                    mStartPointLoc = await response.Content.ReadAsStringAsync();

                    return mStartPointLoc;
                }
                else
                {
                    return null;
                }
            }
        
        }

        public string LoadMidPointOneLocation(string mMidPointOneLocUrl)
        {

            return mMidPointOneLoc;
        }

        public string LoadEndPointLocation(string mMidPointOneLocUrl)
        {

            return mEndPointLoc;
        }

        public string StartPointLocUrl
        {
            get
            {
                return mStartPointLocUrl;
            }
            set
            {
                this.mStartPointLocUrl = value;
            }
        }

        public string MidPointOneLocUrl
        {
            get
            {
                return mMidPointOneLocUrl;
            }
            set
            {
                this.mMidPointOneLocUrl = value;
            }
        }

        public string EndPointLocUrl
        {
            get
            {
                return mEndPointLocUrl;
            }
            set
            {
                this.mEndPointLocUrl = value;
            }
        }
    }
}
