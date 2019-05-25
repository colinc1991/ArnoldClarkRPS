using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    class Paper : BaseClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Paper()
        {
            strengths.Add("Rock");
            strengths.Add("Spock");
            weaknesses.Add("Scissors");
            weaknesses.Add("Lizard");
        }
    }
}