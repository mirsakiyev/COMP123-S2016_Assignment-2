using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment_2
{
     class SuperHero:Hero
    {
        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        private string[] _superPowers;

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
            //_generateRandomPowers();
        }
    }
}
