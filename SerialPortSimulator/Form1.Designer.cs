namespace SerialPortSimulator
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.ConnectBtn = new System.Windows.Forms.Button();
      this.DisConnectBtn = new System.Windows.Forms.Button();
      this.SendBtn = new System.Windows.Forms.Button();
      this.BarCodeTb = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.ProductInfoTb = new System.Windows.Forms.TextBox();
      this.lengthOfCode = new System.Windows.Forms.TextBox();
      this.randomCodeCb = new System.Windows.Forms.CheckBox();
      this.SerialPortsCb = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.startStopButton = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ConnectBtn
      // 
      this.ConnectBtn.Location = new System.Drawing.Point(276, 207);
      this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.ConnectBtn.Name = "ConnectBtn";
      this.ConnectBtn.Size = new System.Drawing.Size(100, 28);
      this.ConnectBtn.TabIndex = 0;
      this.ConnectBtn.Text = "Connect";
      this.toolTip1.SetToolTip(this.ConnectBtn, "Connect to the selected Com port.");
      this.ConnectBtn.UseVisualStyleBackColor = true;
      this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
      // 
      // DisConnectBtn
      // 
      this.DisConnectBtn.Location = new System.Drawing.Point(276, 242);
      this.DisConnectBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.DisConnectBtn.Name = "DisConnectBtn";
      this.DisConnectBtn.Size = new System.Drawing.Size(100, 28);
      this.DisConnectBtn.TabIndex = 1;
      this.DisConnectBtn.Text = "Disconnect";
      this.toolTip1.SetToolTip(this.DisConnectBtn, "Disconnects from the Com port.");
      this.DisConnectBtn.UseVisualStyleBackColor = true;
      this.DisConnectBtn.Click += new System.EventHandler(this.DisConnectBtn_Click);
      // 
      // SendBtn
      // 
      this.SendBtn.Location = new System.Drawing.Point(276, 278);
      this.SendBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SendBtn.Name = "SendBtn";
      this.SendBtn.Size = new System.Drawing.Size(100, 28);
      this.SendBtn.TabIndex = 2;
      this.SendBtn.Text = "Send";
      this.toolTip1.SetToolTip(this.SendBtn, "Click to send a single barcode.");
      this.SendBtn.UseVisualStyleBackColor = true;
      this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
      // 
      // BarCodeTb
      // 
      this.BarCodeTb.Location = new System.Drawing.Point(16, 278);
      this.BarCodeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.BarCodeTb.Name = "BarCodeTb";
      this.BarCodeTb.Size = new System.Drawing.Size(232, 22);
      this.BarCodeTb.TabIndex = 3;
      this.toolTip1.SetToolTip(this.BarCodeTb, "Key in a bar code.");
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(31, 246);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 17);
      this.label1.TabIndex = 4;
      this.label1.Text = "Bar code";
      // 
      // serialPort1
      // 
      this.serialPort1.PortName = "COM3";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.ProductInfoTb);
      this.groupBox1.Controls.Add(this.lengthOfCode);
      this.groupBox1.Controls.Add(this.randomCodeCb);
      this.groupBox1.Location = new System.Drawing.Point(27, 15);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(180, 178);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Autoproduct";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 105);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(131, 17);
      this.label3.TabIndex = 4;
      this.label3.Text = "Product information";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(15, 50);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 17);
      this.label2.TabIndex = 3;
      this.label2.Text = "Start position";
      // 
      // ProductInfoTb
      // 
      this.ProductInfoTb.Location = new System.Drawing.Point(9, 124);
      this.ProductInfoTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.ProductInfoTb.Name = "ProductInfoTb";
      this.ProductInfoTb.Size = new System.Drawing.Size(119, 22);
      this.ProductInfoTb.TabIndex = 2;
      this.toolTip1.SetToolTip(this.ProductInfoTb, "The number of products, up to 9.");
      // 
      // lengthOfCode
      // 
      this.lengthOfCode.Location = new System.Drawing.Point(8, 73);
      this.lengthOfCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.lengthOfCode.Name = "lengthOfCode";
      this.lengthOfCode.Size = new System.Drawing.Size(120, 22);
      this.lengthOfCode.TabIndex = 1;
      this.toolTip1.SetToolTip(this.lengthOfCode, "Sets the start position of the product information. Should correspond to the sett" +
        "ings in Barcode settings in the MMII software.");
      // 
      // randomCodeCb
      // 
      this.randomCodeCb.AutoSize = true;
      this.randomCodeCb.Location = new System.Drawing.Point(8, 23);
      this.randomCodeCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.randomCodeCb.Name = "randomCodeCb";
      this.randomCodeCb.Size = new System.Drawing.Size(116, 21);
      this.randomCodeCb.TabIndex = 0;
      this.randomCodeCb.Text = "RandomCode";
      this.toolTip1.SetToolTip(this.randomCodeCb, "If selected, a random code based on the settings will be generated.");
      this.randomCodeCb.UseVisualStyleBackColor = true;
      // 
      // SerialPortsCb
      // 
      this.SerialPortsCb.FormattingEnabled = true;
      this.SerialPortsCb.Location = new System.Drawing.Point(224, 48);
      this.SerialPortsCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.SerialPortsCb.Name = "SerialPortsCb";
      this.SerialPortsCb.Size = new System.Drawing.Size(160, 24);
      this.SerialPortsCb.TabIndex = 6;
      this.toolTip1.SetToolTip(this.SerialPortsCb, "Select the serial port on the list before connecting.");
      this.SerialPortsCb.SelectedIndexChanged += new System.EventHandler(this.SerialPortsCb_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(220, 28);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(34, 17);
      this.label4.TabIndex = 7;
      this.label4.Text = "Port";
      // 
      // startStopButton
      // 
      this.startStopButton.Location = new System.Drawing.Point(276, 314);
      this.startStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.startStopButton.Name = "startStopButton";
      this.startStopButton.Size = new System.Drawing.Size(100, 28);
      this.startStopButton.TabIndex = 8;
      this.startStopButton.Text = "Start";
      this.toolTip1.SetToolTip(this.startStopButton, "Click \'Start\' to send a barcode for each new sample.");
      this.startStopButton.UseVisualStyleBackColor = true;
      this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(397, 357);
      this.Controls.Add(this.startStopButton);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.SerialPortsCb);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BarCodeTb);
      this.Controls.Add(this.SendBtn);
      this.Controls.Add(this.DisConnectBtn);
      this.Controls.Add(this.ConnectBtn);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "Form1";
      this.Text = "Serial Barcode Simulator";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ConnectBtn;
    private System.Windows.Forms.Button DisConnectBtn;
    private System.Windows.Forms.Button SendBtn;
    private System.Windows.Forms.TextBox BarCodeTb;
    private System.Windows.Forms.Label label1;
    private System.IO.Ports.SerialPort serialPort1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ProductInfoTb;
    private System.Windows.Forms.TextBox lengthOfCode;
    private System.Windows.Forms.CheckBox randomCodeCb;
    private System.Windows.Forms.ComboBox SerialPortsCb;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button startStopButton;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

