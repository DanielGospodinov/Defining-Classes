using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Display
    {
        private double size;
        private string numberOfColors;

        //Constructors
        public Display()
        {
            this.size = 0.0d;
            this.numberOfColors = String.Empty;
        }
        public Display(double size)
        {
            this.size = size;
            this.numberOfColors = String.Empty;
        }
        public Display(double size, string numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        //Properties
        public double Size
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
