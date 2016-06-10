using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment_2
{
     class SuperHero:Hero
    {
        Random rnd = new Random();


        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        private string[] _superPowers = new string[6];

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
        public string[] SuperPowers
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
            
            

            string randomPower_1="";
            string randomPower_2="";
            string randomPower_3="";

            _superPowers[0] = "Super Speed";
            _superPowers[1] = "Super Strength";
            _superPowers[2] = "Body Armour";
            _superPowers[3] = "Flight";
            _superPowers[4] = "Fire Generation";
            _superPowers[5] = "Weather Control";

            int tmp = 0;

            for (int i = 0; i < 3; i++)
            {            
                int indexForRandomPower = 0;

                indexForRandomPower = rnd.Next(1, 7);
                Console.WriteLine(_superPowers[indexForRandomPower]);
                 

            }
            
            
                        
        }






    }
}
