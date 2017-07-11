using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierPractice
{
    class Boat
    {
        // so far we've done fields as private, but we can also do them as public
        public int numberOfPassengers;

        // fields are usually private
        private string name;
        private string engineSize;

        // properties are usually public
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // constructors always have a public access modifier so you can use it in main method
        public Boat()
        {
            // default constructor
        }

        // methods - can be public or private, but are usually public
        public void Move()
        {
            //code to make the boat move
        }

        private double CalculateMPG()
        {
            double MPG = 20.0;
            //code to calculate the MPG
            return MPG;
        }

        // create a class cell phone and determine the
        // 3 fields
        // 2 properties
        // 4 methods
        // for each of the members you created, determine whether it should be public or private


    }
}
