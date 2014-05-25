using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialCommander
{
    public class KeyboardControllerFactory
    {
        public static KeyboardController GetWasdController()
        {
            KeyboardController controller = new KeyboardController();
            controller.MaxValue = 1.0f;
            controller.Name = "WASD";
            controller.KeyDownCommands.Add(Keys.W, new SerialPacket(0.0f, controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.A, new SerialPacket(-controller.MaxValue, controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.S, new SerialPacket(0.0f, -controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.D, new SerialPacket(-controller.MaxValue, -controller.MaxValue));
            controller.KeyUpCommands.Add(Keys.W, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.S, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.A, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.D, new SerialPacket(0.0f, 0.0f));
            return controller;
        }
        public static KeyboardController GetArrowKeysController()
        {
            KeyboardController controller = new KeyboardController();
            controller.Name = "Arrow Keys";
            controller.MaxValue = 1.0f;
            controller.KeyDownCommands.Add(Keys.Up, new SerialPacket(0.0f, controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.Left, new SerialPacket(-controller.MaxValue, controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.Down, new SerialPacket(0.0f, -controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.Right, new SerialPacket(-controller.MaxValue, -controller.MaxValue));
            controller.KeyUpCommands.Add(Keys.Up, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.Left, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.Down, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.Right, new SerialPacket(0.0f, 0.0f));
            return controller;
        }
        public static KeyboardController GetIjklController()
        {
            KeyboardController controller = new KeyboardController();
            controller.Name = "IJKL";
            controller.MaxValue = 1.0f;
            controller.KeyDownCommands.Add(Keys.I, new SerialPacket(0.0f, controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.J, new SerialPacket(-controller.MaxValue, controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.K, new SerialPacket(0.0f, -controller.MaxValue));
            controller.KeyDownCommands.Add(Keys.L, new SerialPacket(-controller.MaxValue, -controller.MaxValue));
            controller.KeyUpCommands.Add(Keys.I, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.J, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.K, new SerialPacket(0.0f, 0.0f));
            controller.KeyUpCommands.Add(Keys.L, new SerialPacket(0.0f, 0.0f));
            return controller;
        }
    }
}
