using System;
using System.Collections.Generic;

namespace Rounding
{
    internal class Inventory
    {
        private double v;
        private IRoundingCommand _rounder;

        public Inventory(double v)
        {
            this.v = v;
        }

        private Inventory(double v, IRoundingCommand command)
        {
            this.v = v;
            this._rounder = command;
        }

        internal double GetRoundedValue()
        {
            return _rounder.roundDouble(v);
        }

        internal Inventory SetRounder(IRoundingCommand command)
        {
            this._rounder = command;
            return new Inventory(v,command);
        }
    }
}