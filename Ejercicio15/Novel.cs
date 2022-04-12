using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio15
{
    class Novel : IWritable
    {
        public string Writer;
        public string Name;


        public Novel(string Writer, string Name)
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
