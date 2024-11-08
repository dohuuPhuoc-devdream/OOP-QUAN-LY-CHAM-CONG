using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    public class Shift
    {
        public DateTime? StartShift { get; private set; }
        public DateTime? EndShift { get; private set; }

        public Shift(DateTime startShift)
        {
            StartShift = startShift;
        }

        public void EndCurrentShift(DateTime endShift)
        {
            EndShift = endShift;
        }
    }

}
