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
    class Program
    {
        // Precondition:  NA
        // Postcondition: The Address classes, Letter classes, and Parcel List is created with test information.
        static void Main(string[] args)
        {

            // 4 addresses are specified here
            Address address1 = new Address("Maria Thomas", "2392 Lauren Drive", "Sun River", "MT", 59483);
            Address address2 = new Address("John Ruiz", "80 Grant Street", "Longview", "TX", 75604);
            Address address3 = new Address("Cynthia Toler", "1247 Watson Lane", "Floresville", "TX", 78114);
            Address address4 = new Address("Steven Damon", "278 Bee Street", "Grand Rapids", "MI", 49508);

            // 4 letters are specified here
            Letter letter1 = new Letter(address1, address2, 3.99M);
            Letter letter2 = new Letter(address1, address3, 4.99M);
            Letter letter3 = new Letter(address3, address4, 2.99M);
            Letter letter4 = new Letter(address4, address1, 5.99M);

            // Parcel List is created
            List<Parcel> letterList = new List<Parcel> { letter1, letter2, letter3, letter4 } ;
            
            // Foreach loop goes over each parcel and lists data
            foreach (Parcel parcel in letterList)
            {
                Console.WriteLine(parcel);
            }
        }
    }
}
