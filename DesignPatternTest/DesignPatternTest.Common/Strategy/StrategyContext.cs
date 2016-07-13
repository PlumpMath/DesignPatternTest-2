using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public class StrategyContext
    {
        private Strategy strategy;

        public StrategyContext(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }
    }
}
