using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinRing0_Test
{
    public partial class Form1 : Form
    {
        private TestByWinRing0 testByWinRing0 = null;

        public Form1()
        {
            InitializeComponent();
            Init_Driver();
        }

        private void Init_Driver()
        {
            testByWinRing0 = new TestByWinRing0();
            bool initResult = testByWinRing0.Initialize();
            if (!initResult)
            {
                label1.Text = "初始化失败！";
                label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label1.Text = "初始化成功！";
                testByWinRing0.InitSuperIO();
                String chipname = testByWinRing0.GetChipName();
                chip_name.Text = chipname;

                testByWinRing0.InitEc();
                fan_ram.Text = "" + testByWinRing0.GetFanRpm();
            }
        }




    }

    
}
