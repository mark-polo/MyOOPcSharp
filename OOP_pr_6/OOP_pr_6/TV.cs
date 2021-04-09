using System;
namespace OOP_pr_6
{
    public class TV
    {
        public int cost;
        public int diagonal;
        public double weight;
        public string model;
        public string screen_resolution;
        public string country;
        public string channel;
        public bool watchNetflix;
        public string netflixSerial;

        public double instalments (int month)
        {
            return cost / month;
        }

    }
}
