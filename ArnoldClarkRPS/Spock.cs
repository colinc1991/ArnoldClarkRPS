using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    class Spock : BaseClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Spock()
        {
            strengths.Add("Scissors");
            strengths.Add("Rock");
            weaknesses.Add("Paper");
            weaknesses.Add("Lizard");
        }
    }
}