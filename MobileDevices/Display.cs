using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevices
{
    class Display
    {
        private double? size;
        private string numberOfColors;

        //Constructors
        public Display()
        {
        }
        public Display(double size)
        {
            this.size = size;
        }
        public Display(double size, string numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        //Properties
        public double? Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
