using System;
using System.Collections.Generic;
using System.Text;

namespace WinRing0_Test
{
    public class TestByWinRing0
    {
        private static OpenLibSys.Ols MyOls;
        public static ushort ec_addr_port;
        public static ushort ec_data_port;

        public bool Initialize()
        {
            MyOls = new OpenLibSys.Ols();
            return MyOls.GetStatus() == (uint)OpenLibSys.Ols.Status.NO_ERROR;
        }

        private static int SuperIo_Inw(byte data)
        {
            int val;
            MyOls.WriteIoPortByte(0x2e, data++);
            val = MyOls.ReadIoPortByte(0x2f) << 8;
            Console.WriteLine("SuperIo_Inw  val1:" + Convert.ToString(val,16));
            MyOls.WriteIoPortByte(0x2e, data);
            val |= MyOls.ReadIoPortByte(0x2f);
            Console.WriteLine("SuperIo_Inw  val2:" + Convert.ToString(val,16));
            return val;
        }

        public void InitSuperIO()
        {
            MyOls.WriteIoPortByte(0x2e, 0x87);
            MyOls.WriteIoPortByte(0x2e, 0x01);
            MyOls.WriteIoPortByte(0x2e, 0x55);
            MyOls.WriteIoPortByte(0x2e, 0x55);
        }

        public string GetChipName()
        {
            ushort chip_type;
            chip_type = (ushort)SuperIo_Inw(0x20);
            Console.WriteLine("chip type :" + Convert.ToString(chip_type,16));
            return "IT"+ Convert.ToString(chip_type,16);
        }

        //FAN EC（LDN=04h, Index 30h=01）
        public void InitEc()
        {
            //enable ec
            MyOls.WriteIoPortByte(0x2e, 0x07);
            MyOls.WriteIoPortByte(0x2f, 0x04);
            MyOls.WriteIoPortByte(0x2e, 0x30);
            MyOls.WriteIoPortByte(0x2f, 0x01);
            //get ec base addr
            ushort ec_base = (ushort)SuperIo_Inw(0x60);
            Console.WriteLine("ec_base addr:" + Convert.ToString(ec_base, 16));
            ec_addr_port = (ushort)(ec_base + 0x05);
            ec_data_port = (ushort)(ec_base + 0x06);
            Console.WriteLine("ec_addr_port :" + Convert.ToString(ec_addr_port, 16)
                + "  ec_data_port :" + Convert.ToString(ec_data_port, 16));

            MyOls.WriteIoPortByte(ec_addr_port, 0x0c);
            MyOls.WriteIoPortByte(ec_data_port, 0x00);
        }

        public int GetFanRpm()
        {
            int fan_speed = 0;
            int fan_rpm = 0;
            //IT8772E
            //2-3 Reading Registers[7:0] (Index=0Eh-0Fh)
            MyOls.WriteIoPortByte(ec_addr_port, 0x0e);
            byte lval = MyOls.ReadIoPortByte(ec_data_port);
            Console.WriteLine("lval:" + Convert.ToString(lval, 2));

            //2-3 Extended Reading Registers [15:8] (Index=19h-1Ah)
            MyOls.WriteIoPortByte(ec_addr_port, 0x19);
            byte mval = MyOls.ReadIoPortByte(ec_data_port);
            Console.WriteLine("mval:" + Convert.ToString(mval, 2));

            fan_speed = (mval << 8) | lval;
            Console.WriteLine("fan_speed:" + fan_speed);
            fan_rpm = (int)(1.35 * Math.Pow(10, 6) / (fan_speed * 2));
            Console.WriteLine("fan_rpm:" + fan_rpm);

            return fan_rpm;
        }
    }

    
}
