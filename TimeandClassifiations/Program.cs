using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeandClassifiations
{
    // get the current date & time 
    class Program
    {
        static void Main(string[] args)
        {
            // get the current system date & time
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;

            // what is the seconds part of the time just retreived
            int currSecs = currentTime.Second;

            // use these statements for testing
            //currSecs = 0;
            //currSecs = 15;
            //currSecs = 30;
            //currSecs = 45;
            //currSecs = 22;


            // output a message based on what the current seconds is
            switch (currSecs)
	{
                case 0:
                    Console.WriteLine("The new minute is just beginning");
                    break;

                case 15:
                    Console.WriteLine("We're one quarter done");
                    break;

                case 30:
                    Console.WriteLine("Half way there");
                    break;

                case 45:
                    Console.WriteLine("Getting close to done");
                    break;
	
                default:
                    Console.WriteLine("Working on it");
                    break;
	}

            // pause console display
            Console.ReadLine();

        }
    }
}
