using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Extra C# libraries required for network communications
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkToolbox
{
    class Program
    {
        static int lineWidth;

        static void WaitForEnter()
        {
            // Wait for user to press enter
            Console.WriteLine();
            Console.Write("Press Enter to continue...");
            Console.ReadLine();
            Console.WriteLine();
        }

        static int ReadIntFromUser()
        {
            Console.WriteLine("How wide do you want the line?");
            return int.Parse(Console.ReadLine());
        }

        static void DrawHorizontalLine(int LinesToDraw)
        {
            for (int i = 0; i < LinesToDraw; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        static void DisplayIPs(string hostName)
        {
            //-----------------------------------------
            // Display the IP addresses for a host name
            //-----------------------------------------
            // Notice the use of arrays, similar to accessing file names in the assignment
            IPAddress[] ipAddresses = Dns.GetHostAddresses(hostName);

            Console.WriteLine("IP addresses for {0}", hostName);
            for (int i = 0; i < ipAddresses.Length; i++)
            {
                Console.WriteLine(" {0}: {1}", i + 1, ipAddresses[i].ToString());
            }
        }

        static void DisplayHostName(string ipAddress)
        {
            //------------------------------------
            // Display host name for an IP address
            //------------------------------------
            IPHostEntry host = Dns.GetHostEntry(ipAddress);
            Console.WriteLine("Host name for {0}: {1}", ipAddress, host.HostName);
        }

        static void PingHost(string pingHost)
        {
            //--------------------------------------------------
            // Ping a host (check if we can communicate with it)
            //--------------------------------------------------
            Console.WriteLine("Pinging {0}...", pingHost);

            Ping ping = new Ping();
            PingReply pingreply = ping.Send(pingHost); // This may cause your firewall to raise an alert

            Console.WriteLine("Ping Status: {0}", pingreply.Status.ToString());
            Console.WriteLine("Round Trip Time: {0}ms", pingreply.RoundtripTime);
        }

        static void Main(string[] args)
        {
            // Demonstration of some networking features from the C# libraries
            // You are not expected to learn these features, although you should recognise some of the code features
            // The lab exercise is to split this code up into methods

            // Ask user for line width to make it consistent.
            lineWidth = ReadIntFromUser();
            DrawHorizontalLine(lineWidth);

            DisplayIPs("www.google.com");

            WaitForEnter();
            DrawHorizontalLine(lineWidth);

            DisplayHostName("216.58.204.4");

            WaitForEnter();
            DrawHorizontalLine(lineWidth);

            PingHost("127.0.0.1");

            WaitForEnter();
        }
    }
}