using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SilverPriceConverter
{
    public class PriceConverter
    {
        private const double scale = 31.1034807;

        public static double Convert(double usd, double exchange)
        {
            return Math.Round(usd / scale * exchange * 1000, 0);
        }
    }
}
