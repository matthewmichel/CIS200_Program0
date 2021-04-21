// ASSIGNMENT: Program 0
// CLASS: CIS 200-01
// DUE DATE: 9/09/2019
// GRADING ID: M1752

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The parcel is an abstract class that will have two children: Package and Letter

namespace Program0
{
    abstract class Parcel
    {
        private Address _originAddress;
        private Address _destinationAddress;

        // Precondition: NA
        // Postcondition: OriginAddress is set
        public Address OriginAddress
        {
            get
            {
                return _originAddress;
            }
            set
            {
                _originAddress = value;
            }
        }

        // Precondition: NA
        // Postcondition: DestinationAddress is set
        public Address DestinationAddress
        {
            get
            {
                return _destinationAddress;
            }
            set
            {
                _destinationAddress = value;
            }
        }

        public Parcel(Address originAddress, Address destinationAddress)
        {
            OriginAddress = originAddress;
            DestinationAddress = destinationAddress;
        }

        // Precondition: NA
        // Postcondition: NA
        public abstract decimal CalcCost();

        //Precondition:  NA
        //Postcondition:  String is returned with OriginAddress and DestinationAddress and CalcCost
        public override string ToString()
        {
            return $"Origin: {OriginAddress} \n Destination: {DestinationAddress} \n Total Cost: {CalcCost()}";
        }
    }
}
