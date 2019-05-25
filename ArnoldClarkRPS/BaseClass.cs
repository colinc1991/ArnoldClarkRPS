// BaseClass is used to provide a template to the children classes of: Rock, Paper, Scissors, Lizard and Spock

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    abstract class BaseClass
    {
        // attributes
        protected List<String> strengths = new List<string>();
        protected List<String> weaknesses = new List<string>();


        // methods
        public List<string> GetStrengths()
        {
            return strengths;
        }

        public List<string> GetWeaknesses()
        {
            return weaknesses;
        }
    }
}
