using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    class Rock : BaseClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Rock()
        {
            strengths.Add("Scissors");
            strengths.Add("Lizard");
            weaknesses.Add("Paper");
            weaknesses.Add("Spock");
        }
    }
}