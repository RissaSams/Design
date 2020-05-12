using System;
using System.Collections.Generic;
using System.Text;

namespace Design
{
    class Phone
    {
        string brand, model;
        int gen;

        public Phone(string brand, string model, int gen)
        {
            this.Brand = brand;
            this.Model = model;
            this.Gen = gen;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int Gen { get => gen; set => gen = value; }

        public override string ToString()
        {
            return "The phone is a(n) " + Brand + " " + Model + " " + Gen + ".";
        }
    }
}
