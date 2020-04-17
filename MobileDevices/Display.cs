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
        private long numberOfColors;
        public Display()
        {
            this.size = 0.0d;
            this.numberOfColors = 0L;
        }
        public Display(double size)
        {
            this.size = size;
            this.numberOfColors = 0L;
        }
        public Display(double size, long numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public long NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }
    }
}
