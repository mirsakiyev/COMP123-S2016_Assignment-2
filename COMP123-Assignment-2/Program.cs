using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Assignment #2
 * Author : Aslan Mirsakiyev
 * Student ID : 300850326
 * Date : 06.09.2016
 * Submitted to : Tom Tsiliopoulos
 * GitHub link : https://github.com/mirsakiyev/COMP123-S2016_Assignment-2.git
 *
 */
namespace COMP123_Assignment_2
{
    /**
     * This class is the driver class for our Program
     * 
     * @class Program
     */
class Program
    {
        /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------------
            //----------------Create a new instance(superman) of the SuperHero class------------------------
            //----------------------------------------------------------------------------------------------
            SuperHero superman = new SuperHero("Superman");


            /**
            * This is a basic do while loop which asks user 
            * how many times he wants to run methods
            * 
            * while (userAnswer=="yes")
            */
            string userAnswer = "";
            do
            {

                superman.Fight();
                superman.Show();
                Console.WriteLine();
                Console.WriteLine("Try again?");
                Console.WriteLine("if YES type 'yes' and press enter key");
                Console.WriteLine("if NO just press enter key");
                userAnswer = Console.ReadLine();
            }
            while (userAnswer == "yes");
            Console.WriteLine();

        }
    }
}
