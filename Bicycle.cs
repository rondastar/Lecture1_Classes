using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1_Classes
{
    internal class Bicycle
    {
        // Shortcuts
        // to comment out - ctrl + k + c
        //to uncomment - ctrl + k + u

        // QUICK ACTION
        // click on light bulb
        // right click and select
        // alt + enter
        // ctrl + .

        // INTELLISENSE
        // ctrl + space

        // 4 components of Classes:
        // Fields
        // Constructor
        // Properties
        // Methods
        
        enum TypesOfChains { Chain1, Chain2, Chain3 }
        // Fields
        string _brakes;
        TypesOfChains _chain;
        string _typeOfWheels;
        int _numberOfGears;
        string _frame;
        string _pedals;
        string _handle;
        int _numberOfSeats;
        public string _uniqueSerial;

        // Constructor
        public Bicycle()
        {
            Random random = new Random();
            int unique = random.Next(100000000, 1000000000);
            _uniqueSerial = unique.ToString();
        }

        // Properties
        public string Brakes { get => _brakes; set => _brakes = value; }
        private TypesOfChains Chain { get => _chain; set => _chain = value; }
        public string TypeOfWheels { get => _typeOfWheels; set => _typeOfWheels = value; }
        public int NumberOfGears { get => _numberOfGears; set => _numberOfGears = value; }
        public string Frame { get => _frame; set => _frame = value; }
        public string Pedals { get => _pedals; set => _pedals = value; }
        public string Handle { get => _handle; set => _handle = value; }
        public int NumberOfSeats 
        { 
            get => _numberOfSeats;
            set 
            { 
                if (value >= 0)
                {
                    _numberOfSeats = value;
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer");
                }
            }  
        }
        public string UniqueSerial
        {
            get => _uniqueSerial;
        }

        // Methods
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
