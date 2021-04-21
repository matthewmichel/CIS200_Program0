
// ASSIGNMENT: Program 0
// CLASS: CIS 200-01
// DUE DATE: 9/09/2019
// GRADING ID: M1752

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program0
{
    class Address
    {
        private string _name; // Name of the person at address
        private string _addressLine1; // 1st line of the address
        private string _addressLine2; // 2nd line of the address
        private string _city; // city for address
        private string _state; // state for address
        private int _zip;

        public const int MIN_ZIP = 00000; // Lowest zipcode value
        public const int MAX_ZIP = 99999; // Highest zipcode value

        public string Name
        {
            // Precondition: NA
            // Postcondition: Name is set to input value
            get
            {
                return _name;
            }
            // Precondition:  Should not contain a null or be just whitespace
            // Postcondition: Name set to value unless improper value specified
            set
            {
                string trimmed = value.Trim(' ');
                if(String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Name)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public string AddressLine1
        {
            // Precondition: NA
            // Postcondition: AddressLine1 is set to input value
            get
            {
                return _addressLine1;
            }
            // Precondition:  Should not contain a null or be just whitespace
            // Postcondition: AddressLine1 set to value unless improper value specified
            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(AddressLine1)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public string AddressLine2
        {
            // Precondition: NA
            // Postcondition: AddressLine2 is set to input value
            get
            {
                return _addressLine2;
            }
            // Precondition:  Should not contain a null or be just whitespace
            // Postcondition: AddressLine2 set to value unless improper value specified
            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(AddressLine2)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public string City
        {
            // Precondition: NA
            // Postcondition: City is set to input value
            get
            {
                return _city;
            }
            // Precondition:  Should not contain a null or be just whitespace
            // Postcondition: City set to value unless improper value specified
            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(City)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public string State
        {
            // Precondition: NA
            // Postcondition: State is set to input value
            get
            {
                return _state;
            }
            // Precondition:  Should not contain a null or be just whitespace
            // Postcondition: State set to value unless improper value specified
            set
            {
                string trimmed = value.Trim(' ');
                if (String.IsNullOrWhiteSpace(trimmed))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(State)} cannot be empty.");
                }
                else
                {
                    _name = trimmed;
                }
            }
        }

        public int Zip
        {
            // Precondition: NA
            // Postcondition: Zip is set to input value
            get
            {
                return _zip;
            }
            // Precondition:  Should not contain a null or be just whitespace
            // Postcondition: Zip set to value unless improper value specified
            set
            {
                if(value < MIN_ZIP || value > MAX_ZIP)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Zip)} cannot be empty.");
                }
                else
                {
                    _zip = value;
                }
            }
        }

        // Precondition: Zip must be lower than MAX_ZIP but higher than MIN_ZIP
        // name, addressLine1, addressLine2, city, state must be non-null values that are not whitespace
        // PostCondition: A new Address is created with values for Name, AddressLine1, AddressLine2, City, State, and Zip
        public Address(string name, string addressLine1, string addressLine2, string city, string state, int zip)
        {
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            Zip = zip;
        }

        // Precondition: Zip must be lower than MAX_ZIP but higher than MIN_ZIP
        // name, addressLine1, city, state must be non-null values that are not whitespace
        // PostCondition: A new Address is created with values for Name, AddressLine1, City, State, and Zip
        public Address(string name, string addressLine1, string city, string state, int zip)
        {
            Name = name;
            AddressLine1 = addressLine1;
            City = city;
            State = state;
            Zip = zip;
        }

        // Precondition: NA
        // Postcondition: A string is returned with the contents of the Address
        //public override string ToString()
        //{
        //    if (string.IsNullOrWhiteSpace(AddressLine2))
        //    {
        //        return Name + "\n" + AddressLine1 + "\n" + City + ", " + State + " " + $"{Zip:d5}";
        //    }
        //    else
        //    {
        //        return $"{Name}\n{AddressLine1}\n{AddressLine2}\n{City}, {State} {Zip:d5}";
        //    }
        //}

        public override string ToString()
        {
            if (AddressLine2 == "")
                return $"\n{Name}" +
                       $"\n{AddressLine1}" +
                       $"\n{City}, {State} {Zip:D5}";
            else
                return $"\n{Name}" +
                   $"\n{AddressLine1}" +
                   $"\n{AddressLine2}" +
                   $"\n{City}, {State} {Zip:D5}";
        }
    }
}
