using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxListingNonStringObjects
{
    class Car
    {
        public string Name { get; set; }
        public int TopSpeed { get; set; }
        public bool IsSedan { get; set; }
        public Color BodyColor { get; set; }

        public override string ToString()
        {
            return Name + " with a top speed of " + TopSpeed.ToString();
        }
    }
}
