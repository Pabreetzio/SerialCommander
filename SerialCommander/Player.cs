using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommander
{
    public class Player
    {
        public SerialPort Port {get;set;}
        public bool Connected { get; set; }
        public string Name { get; set; }
        public Controller Controller {get; set;}
        public Player()
        {
            Connected = false;
            Name = "Player" + PlayerCount;
            PlayerCount++;
        }
        static Player()
        {
            PlayerCount = 1;
        }
        public static int PlayerCount
        {
            get;
            private set;
        }
        public void Connect()
        {
            if (!Connected)
            {
                    Port.Open();
                    Connected = true;
            }
            else
            {
                Port.Close();
                Connected = false;
            }
        }
    }
}
