using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCommander
{
    
    public class KeyboardController : Controller
    {
        public Dictionary<Keys, SerialPacket> KeyDownCommands;
        public Dictionary<Keys, SerialPacket> KeyUpCommands;
        public KeyboardController()
        {
            KeyDownCommands = new Dictionary<Keys, SerialPacket>();
            KeyUpCommands = new Dictionary<Keys, SerialPacket>();
        }
        public override void HandleKeyDown(KeyEventArgs e)
        {
            foreach (KeyValuePair<Keys, SerialPacket> command in KeyDownCommands)
            {
                _HandleCommand(command, e);
            }
        }
        public override void HandleKeyUp(KeyEventArgs e)
        {
            foreach (KeyValuePair<Keys, SerialPacket> command in KeyUpCommands)
            {
                _HandleCommand(command, e);
            }
        }
        public void _HandleCommand(KeyValuePair<Keys, SerialPacket> command, KeyEventArgs e)
        {
            if (Port is SerialPort && Port.IsOpen && e.KeyCode == command.Key)
            {
                var tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                int timeOut = 1000; // 1000 ms

                var task = Task.Factory.StartNew(() => Port.Write(command.Value.Bytes, 0, 6), token);

                //if (!task.Wait(timeOut, token))
                //    Console.WriteLine("The Task timed out!");
                
            }
        }
    }
}
