using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArnoldClarkRPS
{
    class Lizard : BaseClass
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Lizard()
        {
            strengths.Add("Paper");
            strengths.Add("Spock");
            weaknesses.Add("Lizard");
            weaknesses.Add("Rock");
        }
    }
}