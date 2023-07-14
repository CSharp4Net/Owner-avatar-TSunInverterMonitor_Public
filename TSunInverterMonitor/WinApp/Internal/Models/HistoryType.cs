using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZZ.TSIM.WinApp.Internal.Models
{
  internal sealed class HistoryType
  {
    public string Key { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
      return Text;
    }
  }
}
