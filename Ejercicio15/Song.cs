using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio15
{
    class Song : IWritable
    {
       public string Name;
       public string Writer;


        public Song(string Name, string Writer)
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
