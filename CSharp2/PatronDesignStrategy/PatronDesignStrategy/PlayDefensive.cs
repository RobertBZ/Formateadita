using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesignStrategy
{
    class PlayDefensive : FootballTeam
    {
        public void EstratgyMatch()
        {
            Console.WriteLine("Jugaran defensivos cuando sea un partido de VISITANTES");
        }
    }
}
