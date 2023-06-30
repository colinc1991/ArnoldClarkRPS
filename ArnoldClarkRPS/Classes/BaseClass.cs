// BaseClass is used to provide a template to the children classes of: Rock, Paper, Scissors, Lizard and Spock

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    class BaseClass
    {
        // attributes
        protected List<String> strengths = new List<string>();
        protected List<String> weaknesses = new List<string>();

        public BaseClass GetChildClass(string gesture)
        {
            switch (gesture.ToLower())
            {
                case "rock":
                    return new Rock();
                case "paper":
                    return new Paper();
                case "scissors":
                    return new Scissors();
                case "lizard":
                    return new Lizard();
                case "spock":
                    return new Spock();
                default:
                    return null;
            }
        }

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
