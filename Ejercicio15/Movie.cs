using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio15
{
    class Movie : IWritable
    {
        public string Name;
        public string Writer;


        public Movie(string Name, string Writer)
        {
            this.Writer = Writer;
            this.Name = Name;
        }
        public string GetNameOfWorks()
        {
            return Name;
        }

        public string GetWriter()
        {
            return Writer;



        }



    }
}
