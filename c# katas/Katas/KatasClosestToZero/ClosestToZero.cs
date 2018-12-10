using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    class ClosestToZero
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Closest
    {
        public static int ClosestIntToZero(List<int> integers)
        {
            if (integers==null || integers.Count == 0)
            {
                throw new System.ArgumentException("List cannot be empty or null", "integers");
            }
            int closest = integers.FirstOrDefault();

            foreach (int integer in integers)
            {
                if (closest == 0)
                    return closest;

                int closestAbs = Math.Abs(closest);
                int intAbs = Math.Abs(integer);
                if (intAbs < closestAbs)
                {
                    closest = integer;                    
                }
                else if (intAbs == closestAbs)
                {
                    if (integer > 0)
                        closest = integer;
                }
            }
            return closest;
        }
    }
}
