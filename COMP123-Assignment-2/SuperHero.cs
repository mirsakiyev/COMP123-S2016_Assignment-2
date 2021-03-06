﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment_2
{
     class SuperHero:Hero
    {
        // creating a random number 
        Random rnd = new Random();


        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        List<string> _superPowers = new List<string>();

        //----------------------------------------------------------------------------------------------
        //-----------------------------PUBLIC PROPERTIES------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * <summary>
         * This is a property for our private _superPowers array
         * </summary>
         * 
         * @property {string} SuperPowers
         */
        public List<string> SuperPowers
        {
            get { return this._superPowers; }
            set { this._superPowers = value; }
        }

        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
       * <summary>
       * This is the constructor that takes the same parameter as the Hero superclass from
       * assignment 1, name (string), and pass its value to the base class.
       * </summary>
       * 
       * @constructor SuperHero
       * @param {string} name
      */
        public SuperHero(string name):base(name)
        {
            this.Name = name;
            _generateRandomPowers();         
        }


        //----------------------------------------------------------------------------------------------
        //------------------------------PRIVATE METHODS-------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
     * <summary>
     * Randomly generates three random superpowers 
     * from the list of 6 powers
     * </summary>
     * 
     * @method _generateRandomPowers
     * @returns {void}
    */
        private void _generateRandomPowers()
        {
            SuperPowers.Add("Super Speed");
            SuperPowers.Add("Super Strength");
            SuperPowers.Add("Body Armour");
            SuperPowers.Add("Flight");
            SuperPowers.Add("Fire Generation");
            SuperPowers.Add("Weather Control");
            Console.WriteLine("       Super Powers: ");
           
            for (int i = 0; i < 3; i++)
            {
                int indexForRandomPower = 0;
                indexForRandomPower = rnd.Next(1, SuperPowers.Count);
                Console.WriteLine(separator);
                Console.WriteLine(" *  " + SuperPowers[indexForRandomPower]);
                SuperPowers.RemoveAt(indexForRandomPower);
            }
            Console.WriteLine(separator);
        }
    }
}
