using System;

namespace CoderNextDoor.DataAccess.HelperServices
{
    public static class HelperServices
    {
        public static string RandomColorCode()
        {
            // Define your colors array
            string[] colors = { "#4FC1E9", "#FE424D", "#1AA6B7", "#967ADC", "#48cfad" };

            // Get a random index
            Random rnd = new Random();
            int r = rnd.Next(colors.Length);

            string randomColor = ((string)colors[r]);
            return randomColor;
        }
    }
}