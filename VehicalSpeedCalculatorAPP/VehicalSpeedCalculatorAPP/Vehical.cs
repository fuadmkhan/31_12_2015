using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace VehicalSpeedCalculatorAPP
{
    class Vehical
    {
        private double maximum = 0;
        private double minimum = 0;
        private double avarage = 0;
        private int counter = 0;

        public double Maximum
        {
            set
            {
                if (maximum == 0) maximum = value;
                else if (value > maximum) maximum = value;
            }
            get
            {
                return maximum;
            }
        }

        public double Minimum
        {
            set
            {
                if (minimum == 0) minimum = value;
                else if (value < minimum) minimum = value;
            }
            get
            {
                return minimum;
            }
        }

        public double Avarage
        {
            
            set
            {
                
                if (avarage == 0) avarage = value;
                else avarage = ((avarage*counter)+value)/(counter+1);
 		        counter++;
            }
            get
            {
                return avarage;
            }
        }

        public void reset()
        {
            avarage = 0;
            maximum = 0;
            minimum = 0;
        }
    }
}
