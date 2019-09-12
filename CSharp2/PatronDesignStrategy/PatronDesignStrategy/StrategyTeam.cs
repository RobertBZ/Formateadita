using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDesignStrategy
{
    class StrategyTeam
    {
        private FootballTeam Team1;
        public StrategyTeam() {

        }
        public void StrategyPlayDefensive()
        {
            this.Team1 = new PlayDefensive();
        }
        public void StrategyPlayAttackers()
        {
            this.Team1 = new PlayAttackers();
        }
        public void StrategyPlayerEjected()
        {
            this.Team1 = new IsPlayerEjected();
        }
        public void EstratgyMatch()
        {
            this.Team1.EstratgyMatch();
        }
    }
}
