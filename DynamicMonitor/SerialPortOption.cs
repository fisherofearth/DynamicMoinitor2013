using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicMonitor
{
    public partial class SerialPortOption : Form
    {
        public SerialPortOption(UInt16 test, out UInt16 test2)
        {
            InitializeComponent();

            test2 = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            // BeginInvoke(delegate DynamicMonitor());


        }

        private void SerialPortOption_Load(object sender, EventArgs e)
        {

        }
    }
}
