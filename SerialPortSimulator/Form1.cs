using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortSimulator
{
  public partial class Form1 : Form
  {
    private Random random;
    private string[] portNames;
    private DataBaseHelper dataBaseHelper;

    public Form1()
    {
      InitializeComponent();
      random = new Random();
      portNames = System.IO.Ports.SerialPort.GetPortNames();
      dataBaseHelper = new DataBaseHelper();
     
      if (portNames.Length > 0)
      {
        foreach (string portName in portNames)
        {
          SerialPortsCb.Items.Add(portName);
        }

        SerialPortsCb.SelectedIndex = 0;
      }
    }

    private void ConnectBtn_Click(object sender, EventArgs e)
    {
      try
      {
        serialPort1.Open();
        serialPort1.BaudRate = Properties.Settings.Default.BaudRate;
        serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), Properties.Settings.Default.Parity);
        serialPort1.DataBits = Properties.Settings.Default.DataBits;
        serialPort1.StopBits = (StopBits) Enum.Parse(typeof(StopBits), Properties.Settings.Default.StopBits);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Could not connect to {serialPort1.PortName}\n {ex.Message}", "Error connecting to serialport.");
      }
    }

    private void DisConnectBtn_Click(object sender, EventArgs e)
    {
      serialPort1.Close();
    }

    private void SendBtn_Click(object sender, EventArgs e)
    {
      SendBarCode();
    }

    private string CreateBarCode()
    {
      StringBuilder codeBuildere = new StringBuilder();
      for (int i = 0; i < int.Parse(lengthOfCode.Text); i++)
      {
        codeBuildere.Append(random.Next(10).ToString());
      }

      codeBuildere.Append(random.Next(1,5));
      return codeBuildere.ToString();
    }

    private void SendBarCode()
    {
      string barCode;

      if (checkBox1.Checked)
      {
        barCode = CreateBarCode();
      }
      else
      {
        barCode = BarCodeTb.Text;
      }

      BarCodeTb.Text = barCode;
      serialPort1.WriteLine(barCode);
    }

    private void SerialPortsCb_SelectedIndexChanged(object sender, EventArgs e)
    {
      serialPort1.PortName = SerialPortsCb.Text;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (dataBaseHelper.NewSample())
      {
        SendBarCode();
      }
    }

    private void startStopButton_Click(object sender, EventArgs e)
    {
      if (startStopButton.Text == "Start")
      {
        timer1.Start();
        startStopButton.Text = "Stop";
        return;
      }

      timer1.Stop();
      startStopButton.Text = "Start";
    }
  }
}
