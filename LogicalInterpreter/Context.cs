using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalInterpreter
{
    public class Context
    {
        private string input;
        private bool output;

        public Context(string input)
        {
            this.input = input;
        }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public bool Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
