using System;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkDevices.Classes
{
    public static class Constants
    {
        public const string settings = "system.txt";
        public const string images = "image";

        public static int CheckStatusPing(string address)
        {
            PingReply reply = new Ping().Send(address, 80);

            if (reply.Status == IPStatus.Success)
                return Convert.ToInt32(reply.RoundtripTime);

            return -1;
        }
    }
}
