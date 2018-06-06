using System;

namespace Rounding
{
    internal class ToTheNearestHundredthRounder : IRoundingCommand
    {
        double IRoundingCommand.roundDouble(double v) => Math.Round(v, 2);
    }
}