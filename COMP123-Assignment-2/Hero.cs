using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment_2
{
    /**
     * This class defines a hero
     *
     * @class Hero
     * @field _name {string}
     */
    public class Hero
    {
        string separator = "--------------------";
        Random rnd = new Random();

        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------


        private int _strength;
        private int _speed;
        private int _health;
        private string _name;


       
        //----------------------------------------------------------------------------------------------
        //-----------------------------PUBLIC PROPERTIES------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
         * <summary>
         * This is a property for our private _name field
         * </summary>
         * 
         * @property {string} Name
         */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }



        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------



        /**
        * <summary>This is the constructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * </summary>
        * 
        * @constructor Hero
        * @param {string} name
       */

        public Hero(string name)
        {
            this.Name = name;
            generateAbilities();
        }

        //----------------------------------------------------------------------------------------------
        //------------------------------PRIVATE METHODS-------------------------------------------------
        //----------------------------------------------------------------------------------------------


        /**
         * <summary>
         * This method randomly generates the ability numbers(1-100) for the 
         * strength, speed and health properties.
         * </summary>
         * 
         * @method generateAbilities
         * @returns {void}
        */
        public void generateAbilities()
        {
            this._strength = rnd.Next(1, 101);
            this._speed = rnd.Next(1, 101);
            this._health = rnd.Next(1, 101);
        }


        /**
        * <summary>
        * This method will randomly determine if the Hero hits(this should be only 20% of the time)    
        * otherwise it will return false.
        * </summary>
        * 
        * @method hitAttempt
        * @returns {bool}
       */
        private bool hitAttempt()
        {
            /*
            * 20% is the same as 1/5
            * Therefore we can assume that a chance to get a number "tree" from 
            * our random generation(numbers from 1 to 5) is equals to 20% 
            */

            if (rnd.Next(1, 6) == 3)
            {
                Console.WriteLine();
                Console.WriteLine("   -= S M A S H =-");
                Console.WriteLine();
                Console.WriteLine("     " + Name + " HITS");
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("     " + Name + " DIDN'T HIT   :(");
                return false;
            }

        }



        /**
     * <summary>
     * This method calculates the damage the Hero causes to the target
     * on a hit.The damage will be calculated by multiplying the Hero’s
     * strength property by a number between 1 and 6.
     * </summary>
     * 
     * @method hitDamage
     * @returns damage
    */

        private int hitDamage(int strength)
        {

            int damage;
            Console.WriteLine();
            int randomNum = rnd.Next(1, 7);
            damage = strength * randomNum;
            Console.WriteLine("     DAMAGE: " + damage);
            return damage;

        }




        //----------------------------------------------------------------------------------------------
        //-------------------------------PUBLIC METHODS-------------------------------------------------
        //----------------------------------------------------------------------------------------------


        /**
         * <summary>
         * This method calls the private hitAttempt method. If hitAttempt returns true,
         * then it will call the private hitDamage method. The damage amount will then be
         * displayed in a message on the Console.
         * </summary>
         * 
         * @method Fight
         * @returns {void}
        */
        public void Fight()
        {
            if (hitAttempt())
            {
                hitDamage(this._strength);
            }
            else
            {

            }
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine(separator);
            Console.WriteLine(" * STRENGTH |  " + _strength + "  | ");
            Console.WriteLine(separator);
            Console.WriteLine(" * SPEED    |  " + _speed + "  | ");
            Console.WriteLine(separator);
            Console.WriteLine(" * HEALTH   |  " + _health + "  | ");
            Console.WriteLine(separator);
        }


    }
}
