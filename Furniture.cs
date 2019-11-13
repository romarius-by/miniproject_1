using System;
using System.Collections.Generic;
using System.Text;

namespace miniproject_1
{
    public class Furniture : ISquare
    {
        public string Name;
        public int Square;
        public int Luminosity;

        public Furniture(string Name, int Square)
        {
            this.Name = Name;
            this.Square = Square;
        }

        public Furniture(string Name, int Square, int Luminosity)
        {
            this.Name = Name;
            this.Square = Square;
            this.Luminosity = Luminosity;
        }

    }
}
