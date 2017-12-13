﻿using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WondrousNodaTime.Utility
{
  internal class Formatter
  {
    public string Format(WondrousDate d, string patternText, IFormatProvider formatProvider)
    {
      return $"{d.YearOfEra}-{d.Month}-{d.Day}";
    }
  }
}