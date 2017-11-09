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
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.SerialPortsCb = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.startStopButton = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ConnectBtn
      // 
      this.ConnectBtn.Location = new System.Drawing.Point(207, 168);
      this.ConnectBtn.Name = "ConnectBtn";
      this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
      this.ConnectBtn.TabIndex = 0;
      this.ConnectBtn.Text = "Connect";
      this.ConnectBtn.UseVisualStyleBackColor = true;
      this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
      // 
      // DisConnectBtn
      // 
      this.DisConnectBtn.Location = new System.Drawing.Point(207, 197);
      this.DisConnectBtn.Name = "DisConnectBtn";
      this.DisConnectBtn.Size = new System.Drawing.Size(75, 23);
      this.DisConnectBtn.TabIndex = 1;
      this.DisConnectBtn.Text = "Disconnect";
      this.DisConnectBtn.UseVisualStyleBackColor = true;
      this.DisConnectBtn.Click += new System.EventHandler(this.DisConnectBtn_Click);
      // 
      // SendBtn
      // 
      this.SendBtn.Location = new System.Drawing.Point(207, 226);
      this.SendBtn.Name = "SendBtn";
      this.SendBtn.Size = new System.Drawing.Size(75, 23);
      this.SendBtn.TabIndex = 2;
      this.SendBtn.Text = "Send";
      this.SendBtn.UseVisualStyleBackColor = true;
      this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
      // 
      // BarCodeTb
      // 
      this.BarCodeTb.Location = new System.Drawing.Point(12, 226);
      this.BarCodeTb.Name = "BarCodeTb";
      this.BarCodeTb.Size = new System.Drawing.Size(175, 20);
      this.BarCodeTb.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 200);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
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
      this.groupBox1.Controls.Add(this.checkBox1);
      this.groupBox1.Location = new System.Drawing.Point(20, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(135, 145);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Autoproduct";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 85);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Product information";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Start position";
      // 
      // ProductInfoTb
      // 
      this.ProductInfoTb.Location = new System.Drawing.Point(7, 101);
      this.ProductInfoTb.Name = "ProductInfoTb";
      this.ProductInfoTb.Size = new System.Drawing.Size(90, 20);
      this.ProductInfoTb.TabIndex = 2;
      // 
      // lengthOfCode
      // 
      this.lengthOfCode.Location = new System.Drawing.Point(6, 59);
      this.lengthOfCode.Name = "lengthOfCode";
      this.lengthOfCode.Size = new System.Drawing.Size(91, 20);
      this.lengthOfCode.TabIndex = 1;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(6, 19);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(91, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "RandomCode";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // SerialPortsCb
      // 
      this.SerialPortsCb.FormattingEnabled = true;
      this.SerialPortsCb.Location = new System.Drawing.Point(168, 39);
      this.SerialPortsCb.Name = "SerialPortsCb";
      this.SerialPortsCb.Size = new System.Drawing.Size(121, 21);
      this.SerialPortsCb.TabIndex = 6;
      this.SerialPortsCb.SelectedIndexChanged += new System.EventHandler(this.SerialPortsCb_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(165, 23);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(26, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Port";
      // 
      // startStopButton
      // 
      this.startStopButton.Location = new System.Drawing.Point(207, 255);
      this.startStopButton.Name = "startStopButton";
      this.startStopButton.Size = new System.Drawing.Size(75, 23);
      this.startStopButton.TabIndex = 8;
      this.startStopButton.Text = "Start";
      this.startStopButton.UseVisualStyleBackColor = true;
      this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(298, 290);
      this.Controls.Add(this.startStopButton);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.SerialPortsCb);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.BarCodeTb);
      this.Controls.Add(this.SendBtn);
      this.Controls.Add(this.DisConnectBtn);
      this.Controls.Add(this.ConnectBtn);
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
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.ComboBox SerialPortsCb;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button startStopButton;
    private System.Windows.Forms.Timer timer1;
  }
}

