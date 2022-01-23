using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tooensure.Counter.Models
{
    public class Downloads
    {
        public int Current { get; set; }
        public int Desired { get; set; }
        public int DaysExpected { get; set; }
        public int DaysLeft { get; set; }
        public Downloads()
        {

        }
        public Downloads(int current, int desired, int days)
        {
            Current = current;
            Desired = desired;
            DaysExpected = days;
        }
    }
}
