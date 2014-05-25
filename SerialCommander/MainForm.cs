using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialCommander
{
    public partial class MainForm : Form
    {
        //private bool _Connected;
        //private SerialPort _Port;
        private IEnumerable<SerialPort> SerialPorts;
        private Player activePlayer;
        private List<Player> Players;
        private List<Controller> Controllers;
        public MainForm()
        {
            InitializeComponent();
            UpdateComPorts();
            InitializeComboBoxes();
            this.KeyDown += MainForm_KeyDown;
            this.KeyUp += MainForm_KeyUp;
        }

        private void InitializeComboBoxes()
        {
            Player player1 = new Player();
            activePlayer = player1;
            Players = new List<Player>() { player1 };
            PlayerComboBox.DataSource = Players;
            SerialPortComboBox.DataSource = SerialPorts;
            Controllers = new List<Controller>() {
                KeyboardControllerFactory.GetWasdController(),
                KeyboardControllerFactory.GetIjklController(),
                KeyboardControllerFactory.GetArrowKeysController() 
            };
            ControllerComboBox.DataSource = Controllers;
        }

        private void UpdateComPorts()
        {
            List<SerialPort> serialPorts = SerialPort
                .GetPortNames()
                .Select(p => new SerialPort(p, 9600)).ToList();
            SerialPorts = serialPorts;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                activePlayer.Port = SerialPortComboBox.SelectedItem as SerialPort;
                activePlayer.Controller = ControllerComboBox.SelectedItem as Controller;
                activePlayer.Controller.MaxValue = ((float)PowerTrackBar.Value / (float)(PowerTrackBar.Maximum));
                activePlayer.Controller.Port = activePlayer.Port;
                activePlayer.Connect();
            }
            catch (System.IO.IOException ioException)
            {
                toolStripStatusLabel1.Text = "Unable to connect. IO Exception.";
            }
            catch (UnauthorizedAccessException uaException)
            {
                toolStripStatusLabel1.Text = "Unable to connect. Unauthorized Access.";
            }
            catch (InvalidOperationException uaException)
            {
                toolStripStatusLabel1.Text = "Unable to connect. Invalid Operation.";
            }
            if(activePlayer.Connected){
                ConnectButton.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected to " + activePlayer.Port.PortName;
                SerialPortComboBox.Enabled = false;
            }
            else{
                ConnectButton.Text = "Connect";
                toolStripStatusLabel1.Text = "Disconnected";
                SerialPortComboBox.Enabled = true;
            }
            
        }
        private float MaxValue = 1.0f;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Player player in Players)
            {
                if(player.Controller != null)
                    player.Controller.HandleKeyDown(e);
            }
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Player player in Players)
            {
                if (player.Controller != null)
                    player.Controller.HandleKeyUp(e);
            }
        }

        //private void PowerTrackBar_Scroll(object sender, EventArgs e)
        //{
        //    float newValue = (float)PowerTrackBar.Value / (float)(PowerTrackBar.Maximum);
        //    MaxValue = newValue;
        //    toolStripStatusLabel1.Text = newValue*100 + "% Power";
        //}

        private void PlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activePlayer = PlayerComboBox.SelectedValue as Player;
            if (activePlayer.Port is SerialPort)
            {
                SerialPortComboBox.SelectedIndex = SerialPortComboBox.FindString(activePlayer.Port.PortName);
            }
            if (activePlayer.Controller is Controller)
            {
                ControllerComboBox.SelectedIndex = ControllerComboBox.FindString(activePlayer.Controller.Name);
                PowerTrackBar.Value = (int)(activePlayer.Controller.MaxValue * PowerTrackBar.Maximum);
            }

            ConnectButton.Text = activePlayer.Connected ? "Disconnect" : "Connect";
            toolStripStatusLabel1.Text = "Switched to " + activePlayer.Name;
            SerialPortComboBox.Enabled = !activePlayer.Connected;
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            Player newPlayer = new Player();
            Players.Add(newPlayer);
            PlayerComboBox.DataSource = new List<Player>();
            PlayerComboBox.DataSource = Players; 
            toolStripStatusLabel1.Text = newPlayer.Name + " added";
        }

        private void SerialPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SerialPortComboBox.SelectedItem is SerialPort && activePlayer is Player )
                activePlayer.Port = SerialPortComboBox.SelectedItem as SerialPort;
        }

        private void ControllerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ControllerComboBox.SelectedItem is Controller && activePlayer is Player)
                activePlayer.Controller = ControllerComboBox.SelectedItem as Controller;
        }

    }
}
