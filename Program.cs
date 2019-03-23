using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthWave
{
    class Program
    {

        static void Main()
        {
            
            //Prompt user for number wave forms
            Console.WriteLine("How many wave forms would you like? or type \"quit\" to exity");
            string entry = Console.ReadLine();

            //Display number of Waveforms
            Console.WriteLine("You've chosen " + entry + " Waveforms" + " from the Fairlight CMI");

            Console.ReadLine();

        }
    } 
}
