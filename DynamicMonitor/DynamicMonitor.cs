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
    public partial class DynamicMonitor : Form
    {
        public int config_serialport_ReceivedBytesThreshold = 1;
        public DynamicMonitor()
        {
           
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UInt16 a, b;

            SerialPortOption serialPortOption = new SerialPortOption(1,out b);
            serialPortOption.Show();
           // this.Hide();
            this.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                ShutSerialPort();
            }
            else
                LunchSerialPort(textBox_com.Text, Convert.ToInt32(comboBox_baudrate.Items[comboBox_baudrate.SelectedIndex]));
        }

       
        private void LunchSerialPort(string portName, int baudRate)
        {
            try
            {
                serialPort1.ReceivedBytesThreshold = config_serialport_ReceivedBytesThreshold; 
                serialPort1.PortName = "COM" + portName;
                serialPort1.BaudRate = baudRate;
                serialPort1.Open();
                button1.Text = "Stop";
                button2.BackColor = Color.Green;
                button4.Enabled = true;
            }
            catch
            {
                MessageBox.Show("串口打开发生了悲剧！", "Error");
            }
        }
        private void ShutSerialPort()
        {
            serialPort1.Dispose();

            serialPort1.Close();
            button1.Text = "Start";
            button2.BackColor = Color.Red;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RichTextBox buffer = new RichTextBox();
        
            buffer.Text = textBox1.Text + "\t" + textBox2.Text + "\t" + textBox3.Text + "\t" + textBox4.Text + "\n";
            buffer.Text += richTextBox1.Text;

            buffer.SelectAll();
            buffer.Copy();
        }


        private byte[] buffer = new byte[4096]; 
        private int uart_offset_ptr = 0;
        private int offset;
        private int length;


        byte[] bb = new byte[2];
        bool avtivePackage = false;
        int counter = 0;
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int byteNumber;



            try
            {
                /*serialPort1.Read(buffer, 0, config_serialport_ReceivedBytesThreshold);
 */
                
                serialPort1.Read(bb, 0, 1);

                if (bb[0] == 0xFF )
                {
                    avtivePackage = true;
                    counter = 0;
                    return;
                }

                if (avtivePackage == true)
                {
                    buffer[counter] = bb[0];
                    counter++;
                    if (counter > 4) avtivePackage = false;
                }
               

              /*
                
                byteNumber = serialPort1.BytesToRead;
               serialPort1.Read(buffer, uart_offset_ptr, byteNumber);
              
               
                offset = uart_offset_ptr;

                uart_offset_ptr += byteNumber;

                length = uart_offset_ptr;
                */
                this.Invoke(new mydele(ReadPackageFromBuffer));//委托主线程
            }
            catch
            {
                //serialPort1.Close();
            }
        }

        private delegate void mydele();

        //private int[][] packageData = new int[4][];
        //private int ptr_packageData;
        private void ReadPackageFromBuffer()
        {
          
/*
            for (i = 0; i < config_serialport_ReceivedBytesThreshold; i += 10)
            {
                richTextBox1.Text += Convert.ToString((buffer[i + 2] * 0xFF) + buffer[i + 3]) + "\t";
                richTextBox1.Text += Convert.ToString((buffer[i + 4] * 0xFF) + buffer[i + 5]) + "\t";
                richTextBox1.Text += Convert.ToString((buffer[i + 6] * 0xFF) + buffer[i + 7]) + "\t";
                richTextBox1.Text += Convert.ToString((buffer[i + 8] * 0xFF) + buffer[i + 9]) + "\n";
            }
            */
            richTextBox1.Text += Convert.ToString( buffer[0]) + "\t";
            richTextBox1.Text += Convert.ToString( buffer[1]) + "\t";
            richTextBox1.Text += Convert.ToString( buffer[2]) + "\t";
            richTextBox1.Text += Convert.ToString( buffer[3]) + "\n";
            

            /*
           for (i = offset; i < length; i++)
            {
                if ((length - i - offset) >= config_serialport_ReceivedBytesThreshold)
                {
                    if ((buffer[i] == 0xFF) && (buffer[i + 1] == 0xFF))
                    {
                        richTextBox1.Text += Convert.ToString((buffer[i + 2] * 0xFF) + buffer[i + 3]) + "\t";
                        richTextBox1.Text += Convert.ToString((buffer[i + 4] * 0xFF) + buffer[i + 5]) + "\t";
                        richTextBox1.Text += Convert.ToString((buffer[i + 6] * 0xFF) + buffer[i + 7]) + "\t";
                        richTextBox1.Text += Convert.ToString((buffer[i + 8] * 0xFF) + buffer[i + 9]) + "\n";
                    }
                }
                else 
                {
                    uart_offset_ptr = (length - i - offset);
                    for (j = 0; j < uart_offset_ptr; j++)
                    {
                        buffer[j] = buffer[i+j];
                        return;
                    }
                }
            }
             * */
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
