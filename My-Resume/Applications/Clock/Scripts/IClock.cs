﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Clock
{
    interface IClock
    {
        string Hour();
        string Minute();
        string second();

    }
}
