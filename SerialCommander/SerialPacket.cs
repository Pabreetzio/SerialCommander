using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialCommander
{
    public class SerialPacket
    {
        public Byte[] Bytes {get;set;}
        public SerialPacket(float x, float y)
        {
            byte startByte = (byte)0x02;
            byte endByte = (byte)0x03;
            byte[] xBytes = _ConvertPercentToBytes(x);
            byte[] yBytes = _ConvertPercentToBytes(y);
            byte[] serialBytes = new byte[6] { startByte, xBytes[0], xBytes[1], yBytes[0], yBytes[1], endByte };
            Bytes = serialBytes;
        }

        public string ToString()
        {
            return String.Join(" ", Bytes.Select(b => b.ToString("X2")));
        }

        byte[] _ConvertPercentToBytes(float percent)
        {
            byte byteOne = (byte)0x00;
            byte byteTwo = (byte)0x00;
            int zeroOneOffset = 72;
            int oneTwoOffset = 56;
            int ofOneHundred = (int)(percent * 100);
            if (ofOneHundred > 55)
            {
                byteOne = (byte)0x02;
                byteTwo = (byte)(ofOneHundred - oneTwoOffset);
            }
            else
            {
                if (ofOneHundred < -zeroOneOffset)
                {
                    byteOne = (byte)0x00;
                    byteTwo = (byte)(ofOneHundred + zeroOneOffset - 128);
                }
                else
                {
                    byteOne = (byte)0x01;
                    byteTwo = (byte)(ofOneHundred + zeroOneOffset);
                }
            }
            return new byte[2] { byteOne, byteTwo };
        }
    }
}
