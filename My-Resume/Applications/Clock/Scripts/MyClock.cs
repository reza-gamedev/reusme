using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Clock
{
    class MyClock : IClock
    {
        public string Hour()
        {
            return DateTime.Now.Hour.ToString("D2");
        }

        public string Minute()
        {
            return DateTime.Now.Minute.ToString("D2");
        }

        public string second()
        {
            return DateTime.Now.Second.ToString("D2");
        }
    }
}
