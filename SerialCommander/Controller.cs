using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCommander
{
    public abstract class Controller
    {
        public abstract void HandleKeyDown(KeyEventArgs e);
        public abstract void HandleKeyUp(KeyEventArgs e);
        public string Name { get; set; }
        public float MaxValue { get; set; }
        public SerialPort Port { get; set; }
    }
}
