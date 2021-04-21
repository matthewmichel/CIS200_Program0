// ASSIGNMENT: Program 0
// CLASS: CIS 200-01
// DUE DATE: 9/09/2019
// GRADING ID: M1752


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Letter class is a child of the Parcel class. It has an Origin, a Destination, and a Fixed Cost

namespace Program0
{
    class Letter: Parcel
    {

        private decimal _fixedCost; // Fixed cost of shipping the letter

        protected decimal FixedCost
        {
            //Precondition: NA
            //Postcondition: Returns the value of _fixedCost
            get
            {
                return _fixedCost;
            }
            //Precondition: The value must be greater than or equal to 0
            //Postcondition: _fixedCost is set
            set
            {
                if (value >= 0)
                    _fixedCost = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(FixedCost)} must be a non-negative number.");
            }
        }

        //Precondition:  NA
        //Postcondition:  letterOriginAddress, letterDestinationAddress, and fixedCost are all created in a new Letter object.
        public Letter(Address letterOriginAddress, Address letterDestinationAddress, decimal fixedCost) : base(letterOriginAddress, letterDestinationAddress)
        {
            FixedCost = fixedCost;
        }

        // Precondition:  NA
        // Postcondition: the FixedCost of sending the letter is returned.
        public override decimal CalcCost()
        {
            return FixedCost;
        }

        // Precondition:  NA
        // Postcondition: A string is returned with the OriginAddress, DestinationAddress, and FixedCost
        public override string ToString() => $"{base.ToString()}\n\nCost: {CalcCost():C}";

    }
}
