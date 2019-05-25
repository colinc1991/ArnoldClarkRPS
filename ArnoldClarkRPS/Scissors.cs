using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    class Scissors : BaseClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Scissors()
        {
            strengths.Add("Paper");
            strengths.Add("Lizard");
            weaknesses.Add("Rock");
            weaknesses.Add("Spock");
        }
    }
}