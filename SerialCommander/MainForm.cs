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
        private bool _Connected;
        private SerialPort _Port;
        private ListViewItem[] SerialPorts;
        public MainForm()
        {
            InitializeComponent();
            UpdateComPorts();
            InitializeComboBoxes();
            this.KeyDown += MainForm_KeyDown;
            this.KeyUp += MainForm_KeyUp;
            List<ListViewItem> ControllerLayouts = new List<ListViewItem>() { new ListViewItem("WASD") };
            Player1ControllerComboBox.DataSource = ControllerLayouts.ToArray();
        }

        private void InitializeComboBoxes()
        {
            Player1SerialPortComboBox.DataSource = SerialPorts;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Player1SerialPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UpdateComPorts()
        {
            SerialPorts = SerialPort
                .GetPortNames()
                .Select(p => new ListViewItem(p))
                .ToArray();
        }

        private void Player1ConnectButton_Click(object sender, EventArgs e)
        {
            if (!_Connected)
            {
                string portName = ((ListViewItem)Player1SerialPortComboBox.SelectedItem).Text;
                _Port = new SerialPort(portName, 9600);
                try
                {
                    _Port.Open();
                    _Connected = true;
                    Player1ConnectButton.Text = "Disconnect";
                    toolStripStatusLabel1.Text = "Connected to " + portName;
                }
                catch (System.IO.IOException ioException)
                {
                }
                catch (UnauthorizedAccessException uaException)
                {
                }
            }
            else
            {
                _Port.Close();
                _Connected = false;
                Player1ConnectButton.Text = "Connect";
                toolStripStatusLabel1.Text = "Disconnected";
            }
        }
        private float maxValue = 1.0f;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (_Port != null)
            {
                if (e.KeyCode == Keys.A && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(-maxValue, maxValue);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
                if (e.KeyCode == Keys.W && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(0.0f, maxValue);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
                if (e.KeyCode == Keys.S && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(0.0f, -maxValue);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
                if (e.KeyCode == Keys.D && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(-maxValue, -maxValue);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
            }
        }
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (_Port != null)
            {
                if (e.KeyCode == Keys.A && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(0.0f, 0.0f);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
                if (e.KeyCode == Keys.W && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(0.0f, 0.0f);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
                if (e.KeyCode == Keys.S && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(0.0f, -0.0f);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
                if (e.KeyCode == Keys.D && _Port.IsOpen == true)
                {
                    SerialPacket packet = new SerialPacket(-0.0f, -0.0f);
                    _Port.Write(packet.Bytes, 0, 6);
                    toolStripStatusLabel1.Text = packet.ToString();
                }
            }
        }

        private void PowerTrackBar_Scroll(object sender, EventArgs e)
        {
            float newValue = (float)PowerTrackBar.Value / (float)(PowerTrackBar.Maximum);
            maxValue = newValue;
            toolStripStatusLabel1.Text = newValue*100 + "%";
        }
    }
}
