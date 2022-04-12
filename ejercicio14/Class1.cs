using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio14
{
    struct Point
    {

        private int x_1;
        private int y_1;
        private int x_2;
        private int y_2;

        public int x1
        {

            get
            {
                return x_1;
            }

            set
            {

                x_1 = value;
            }
        }

        public int x2
        {

            get
            {
                return x_2;
            }

            set
            {

                x_2 = value;
            }
        }

        public int y1
        {

            get
            {
                return y_1;
            }

            set
            {

                y_1 = value;
            }
        }

        public int y2
        {

            get
            {
                return y_2;
            }

            set
            {

                y_2 = value;
            }
        }

        public string distance ()
        {
            double x = Math.Pow(x_2 - x_1, 2.0);
            double y = Math.Pow(y_2 - y_1, 2.0);
            double distance =( Math.Sqrt(x + y));
            string result = distance.ToString("0.00");


            return ($"The distance bewteen the to points is {result}");
            
        }


    }
}
