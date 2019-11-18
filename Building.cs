using System;

namespace Planner
{
    class Building
    {
        // Private Fields
        private string _designer = "Heidi";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        public int Height { get; set; }
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        // computing 
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        // constructor 
        public Building(string address)
        {
            _address = address;

        }
        // methods 
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;

        }
        public string Description
        {
            get
            {
                return $"Designed by {_designer} constructed on {_dateConstructed} owned by {_owner} with {Volume} meters of space";
            }
        }

    }
}