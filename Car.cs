using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public double Engine { get; set; }
        public string Colour { get; set; }
        public bool BrandNew { get; set; }


        public Car()
        {
            Make = "Nothing yet";
            Model = "Not produced yet";
            Price = 0.00M;
            Engine = 0.0;
            Colour = "nothing";
            BrandNew = true;
        }

        public Car(string a, string b, decimal c, double d, string e, bool f)
        {
            Make = a;
            Model = b;
            Price = c;
            Engine = d;
            Colour = e;
            BrandNew = f;
        }

        public override string ToString()
        {
            return Make + " " + Model + " R" + Price + " Engine size: " + Engine + " Colour: " + Colour + " Car is new: " + BrandNew;
        }
    }
}
