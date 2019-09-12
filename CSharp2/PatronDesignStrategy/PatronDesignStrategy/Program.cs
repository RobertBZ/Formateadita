using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesignStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPlayerEjected Player = new IsPlayerEjected();
            Player.EstratgyMatch();
            PlayAttackers PlayA = new PlayAttackers();
            PlayA.EstratgyMatch();
            PlayDefensive PlayD = new PlayDefensive();
            PlayD.EstratgyMatch();

            //Console.WriteLine("===============");

            /*StrategyTeam Strategy = new StrategyTeam();
            Strategy.StrategyPlayAttackers();
            Strategy.StrategyPlayDefensive();
            Strategy.StrategyPlayerEjected();*/
            Console.ReadKey();
        }
    }
}
