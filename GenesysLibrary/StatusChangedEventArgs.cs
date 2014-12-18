using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GenesysLibrary
{
    public class StatusChangedEventArgs : EventArgs
    {
        public string Text { get; private set; }

        public StatusChangedEventArgs(string text)
        {
            Text = text;
        }
    }
}
