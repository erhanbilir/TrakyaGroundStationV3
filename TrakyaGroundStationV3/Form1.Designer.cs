namespace TrakyaGroundStationV3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            portPanel = new Panel();
            hyiPortGroupBox = new GroupBox();
            hyiPortActivePanel = new Panel();
            hyiPortButton = new Button();
            hyiBaudRateComboBox = new ComboBox();
            hyiComPortLabel = new Label();
            hyiBaudRateLabel = new Label();
            hyiPortComboBox = new ComboBox();
            payloadPortGroupBox = new GroupBox();
            payloadPortActivePanel = new Panel();
            payloadPortButton = new Button();
            payloadBaudRateComboBox = new ComboBox();
            payloadComPortLabel = new Label();
            payloadBaudRateLabel = new Label();
            payloadPortComboBox = new ComboBox();
            mainPortGroupBox = new GroupBox();
            mainPortActivePanel = new Panel();
            mainPortButton = new Button();
            mainBaudRateComboBox = new ComboBox();
            mainComPortLabel = new Label();
            mainBaudRateLabel = new Label();
            mainPortComboBox = new ComboBox();
            dataPanel = new Panel();
            payloadDataGroupBox = new GroupBox();
            payloadHumidityTextBox = new TextBox();
            payloadLongtitudeTextBox = new TextBox();
            payloadLatitudeTextBox = new TextBox();
            payloadTemperatureTextBox = new TextBox();
            payloadHumidityLabel = new Label();
            payloadGPSAltitudeTextBox = new TextBox();
            payloadTemperatureLabel = new Label();
            payloadAltitudeTextBox = new TextBox();
            payloadLongtitudeLabel = new Label();
            payloadLatitudeLabel = new Label();
            payloadGPSAltitudeLabel = new Label();
            payloadAltitudeLabel = new Label();
            mainDataGroupBox = new GroupBox();
            panel2 = new Panel();
            stage2Label = new Label();
            mainAccelZTextBox = new TextBox();
            mainAccelYTextBox = new TextBox();
            mainAccelXTextBox = new TextBox();
            mainAngelTextBox = new TextBox();
            mainGyroZTextBox = new TextBox();
            mainGyroYTextBox = new TextBox();
            mainGyroXTextBox = new TextBox();
            mainLongtitudeTextBox = new TextBox();
            mainLatitudeTextBox = new TextBox();
            mainGPSAltitudeTextBox = new TextBox();
            mainAltitudeTextBox = new TextBox();
            panel1 = new Panel();
            stage1Label = new Label();
            mainStateLabel = new Label();
            mainAngelLabel = new Label();
            mainAccelZLabel = new Label();
            mainAccelYLabel = new Label();
            mainAccelXLabel = new Label();
            mainGPSAltitudeLabel = new Label();
            mainLongtitudeLabel = new Label();
            mainLaitudeLabel = new Label();
            mainGyroZLabel = new Label();
            mainGyroYLabel = new Label();
            mainGyroXLabel = new Label();
            mainAltitudeLabel = new Label();
            label24 = new Label();
            portPanel.SuspendLayout();
            hyiPortGroupBox.SuspendLayout();
            payloadPortGroupBox.SuspendLayout();
            mainPortGroupBox.SuspendLayout();
            dataPanel.SuspendLayout();
            payloadDataGroupBox.SuspendLayout();
            mainDataGroupBox.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // portPanel
            // 
            portPanel.Controls.Add(hyiPortGroupBox);
            portPanel.Controls.Add(payloadPortGroupBox);
            portPanel.Controls.Add(mainPortGroupBox);
            portPanel.Location = new Point(12, 63);
            portPanel.Name = "portPanel";
            portPanel.Size = new Size(203, 654);
            portPanel.TabIndex = 1;
            // 
            // hyiPortGroupBox
            // 
            hyiPortGroupBox.Controls.Add(hyiPortActivePanel);
            hyiPortGroupBox.Controls.Add(hyiPortButton);
            hyiPortGroupBox.Controls.Add(hyiBaudRateComboBox);
            hyiPortGroupBox.Controls.Add(hyiComPortLabel);
            hyiPortGroupBox.Controls.Add(hyiBaudRateLabel);
            hyiPortGroupBox.Controls.Add(hyiPortComboBox);
            hyiPortGroupBox.Location = new Point(3, 405);
            hyiPortGroupBox.Name = "hyiPortGroupBox";
            hyiPortGroupBox.Size = new Size(197, 195);
            hyiPortGroupBox.TabIndex = 6;
            hyiPortGroupBox.TabStop = false;
            hyiPortGroupBox.Text = "HYI Port";
            // 
            // hyiPortActivePanel
            // 
            hyiPortActivePanel.BackColor = Color.OrangeRed;
            hyiPortActivePanel.Location = new Point(6, 170);
            hyiPortActivePanel.Name = "hyiPortActivePanel";
            hyiPortActivePanel.Size = new Size(185, 19);
            hyiPortActivePanel.TabIndex = 6;
            // 
            // hyiPortButton
            // 
            hyiPortButton.Location = new Point(52, 120);
            hyiPortButton.Name = "hyiPortButton";
            hyiPortButton.Size = new Size(75, 23);
            hyiPortButton.TabIndex = 4;
            hyiPortButton.Text = "Connect";
            hyiPortButton.UseVisualStyleBackColor = true;
            hyiPortButton.Click += hyiPortButton_Click;
            // 
            // hyiBaudRateComboBox
            // 
            hyiBaudRateComboBox.FormattingEnabled = true;
            hyiBaudRateComboBox.Location = new Point(6, 82);
            hyiBaudRateComboBox.Name = "hyiBaudRateComboBox";
            hyiBaudRateComboBox.Size = new Size(121, 23);
            hyiBaudRateComboBox.TabIndex = 3;
            // 
            // hyiComPortLabel
            // 
            hyiComPortLabel.AutoSize = true;
            hyiComPortLabel.Location = new Point(133, 56);
            hyiComPortLabel.Name = "hyiComPortLabel";
            hyiComPortLabel.Size = new Size(60, 15);
            hyiComPortLabel.TabIndex = 2;
            hyiComPortLabel.Text = "COM Port";
            // 
            // hyiBaudRateLabel
            // 
            hyiBaudRateLabel.AutoSize = true;
            hyiBaudRateLabel.Location = new Point(133, 85);
            hyiBaudRateLabel.Name = "hyiBaudRateLabel";
            hyiBaudRateLabel.Size = new Size(60, 15);
            hyiBaudRateLabel.TabIndex = 1;
            hyiBaudRateLabel.Text = "Baud Rate";
            // 
            // hyiPortComboBox
            // 
            hyiPortComboBox.FormattingEnabled = true;
            hyiPortComboBox.Location = new Point(6, 53);
            hyiPortComboBox.Name = "hyiPortComboBox";
            hyiPortComboBox.Size = new Size(121, 23);
            hyiPortComboBox.TabIndex = 0;
            // 
            // payloadPortGroupBox
            // 
            payloadPortGroupBox.Controls.Add(payloadPortActivePanel);
            payloadPortGroupBox.Controls.Add(payloadPortButton);
            payloadPortGroupBox.Controls.Add(payloadBaudRateComboBox);
            payloadPortGroupBox.Controls.Add(payloadComPortLabel);
            payloadPortGroupBox.Controls.Add(payloadBaudRateLabel);
            payloadPortGroupBox.Controls.Add(payloadPortComboBox);
            payloadPortGroupBox.Location = new Point(3, 204);
            payloadPortGroupBox.Name = "payloadPortGroupBox";
            payloadPortGroupBox.Size = new Size(197, 195);
            payloadPortGroupBox.TabIndex = 5;
            payloadPortGroupBox.TabStop = false;
            payloadPortGroupBox.Text = "Payload Port";
            // 
            // payloadPortActivePanel
            // 
            payloadPortActivePanel.BackColor = Color.OrangeRed;
            payloadPortActivePanel.Location = new Point(6, 170);
            payloadPortActivePanel.Name = "payloadPortActivePanel";
            payloadPortActivePanel.Size = new Size(185, 19);
            payloadPortActivePanel.TabIndex = 5;
            // 
            // payloadPortButton
            // 
            payloadPortButton.Location = new Point(52, 120);
            payloadPortButton.Name = "payloadPortButton";
            payloadPortButton.Size = new Size(75, 23);
            payloadPortButton.TabIndex = 4;
            payloadPortButton.Text = "Connect";
            payloadPortButton.UseVisualStyleBackColor = true;
            payloadPortButton.Click += payloadPortButton_Click;
            // 
            // payloadBaudRateComboBox
            // 
            payloadBaudRateComboBox.FormattingEnabled = true;
            payloadBaudRateComboBox.Location = new Point(6, 82);
            payloadBaudRateComboBox.Name = "payloadBaudRateComboBox";
            payloadBaudRateComboBox.Size = new Size(121, 23);
            payloadBaudRateComboBox.TabIndex = 3;
            // 
            // payloadComPortLabel
            // 
            payloadComPortLabel.AutoSize = true;
            payloadComPortLabel.Location = new Point(133, 56);
            payloadComPortLabel.Name = "payloadComPortLabel";
            payloadComPortLabel.Size = new Size(60, 15);
            payloadComPortLabel.TabIndex = 2;
            payloadComPortLabel.Text = "COM Port";
            // 
            // payloadBaudRateLabel
            // 
            payloadBaudRateLabel.AutoSize = true;
            payloadBaudRateLabel.Location = new Point(133, 85);
            payloadBaudRateLabel.Name = "payloadBaudRateLabel";
            payloadBaudRateLabel.Size = new Size(60, 15);
            payloadBaudRateLabel.TabIndex = 1;
            payloadBaudRateLabel.Text = "Baud Rate";
            // 
            // payloadPortComboBox
            // 
            payloadPortComboBox.FormattingEnabled = true;
            payloadPortComboBox.Location = new Point(6, 53);
            payloadPortComboBox.Name = "payloadPortComboBox";
            payloadPortComboBox.Size = new Size(121, 23);
            payloadPortComboBox.TabIndex = 0;
            // 
            // mainPortGroupBox
            // 
            mainPortGroupBox.Controls.Add(mainPortActivePanel);
            mainPortGroupBox.Controls.Add(mainPortButton);
            mainPortGroupBox.Controls.Add(mainBaudRateComboBox);
            mainPortGroupBox.Controls.Add(mainComPortLabel);
            mainPortGroupBox.Controls.Add(mainBaudRateLabel);
            mainPortGroupBox.Controls.Add(mainPortComboBox);
            mainPortGroupBox.Location = new Point(3, 3);
            mainPortGroupBox.Name = "mainPortGroupBox";
            mainPortGroupBox.Size = new Size(197, 195);
            mainPortGroupBox.TabIndex = 0;
            mainPortGroupBox.TabStop = false;
            mainPortGroupBox.Text = "Main Port";
            // 
            // mainPortActivePanel
            // 
            mainPortActivePanel.BackColor = Color.OrangeRed;
            mainPortActivePanel.Location = new Point(6, 170);
            mainPortActivePanel.Name = "mainPortActivePanel";
            mainPortActivePanel.Size = new Size(185, 19);
            mainPortActivePanel.TabIndex = 6;
            // 
            // mainPortButton
            // 
            mainPortButton.Location = new Point(52, 120);
            mainPortButton.Name = "mainPortButton";
            mainPortButton.Size = new Size(75, 23);
            mainPortButton.TabIndex = 4;
            mainPortButton.Text = "Connect";
            mainPortButton.UseVisualStyleBackColor = true;
            mainPortButton.Click += mainPortButton_Click;
            // 
            // mainBaudRateComboBox
            // 
            mainBaudRateComboBox.FormattingEnabled = true;
            mainBaudRateComboBox.Location = new Point(6, 82);
            mainBaudRateComboBox.Name = "mainBaudRateComboBox";
            mainBaudRateComboBox.Size = new Size(121, 23);
            mainBaudRateComboBox.TabIndex = 3;
            // 
            // mainComPortLabel
            // 
            mainComPortLabel.AutoSize = true;
            mainComPortLabel.Location = new Point(133, 56);
            mainComPortLabel.Name = "mainComPortLabel";
            mainComPortLabel.Size = new Size(60, 15);
            mainComPortLabel.TabIndex = 2;
            mainComPortLabel.Text = "COM Port";
            // 
            // mainBaudRateLabel
            // 
            mainBaudRateLabel.AutoSize = true;
            mainBaudRateLabel.Location = new Point(133, 85);
            mainBaudRateLabel.Name = "mainBaudRateLabel";
            mainBaudRateLabel.Size = new Size(60, 15);
            mainBaudRateLabel.TabIndex = 1;
            mainBaudRateLabel.Text = "Baud Rate";
            // 
            // mainPortComboBox
            // 
            mainPortComboBox.FormattingEnabled = true;
            mainPortComboBox.Location = new Point(6, 53);
            mainPortComboBox.Name = "mainPortComboBox";
            mainPortComboBox.Size = new Size(121, 23);
            mainPortComboBox.TabIndex = 0;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(payloadDataGroupBox);
            dataPanel.Controls.Add(mainDataGroupBox);
            dataPanel.Location = new Point(221, 63);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(1111, 654);
            dataPanel.TabIndex = 2;
            // 
            // payloadDataGroupBox
            // 
            payloadDataGroupBox.Controls.Add(payloadHumidityTextBox);
            payloadDataGroupBox.Controls.Add(payloadLongtitudeTextBox);
            payloadDataGroupBox.Controls.Add(payloadLatitudeTextBox);
            payloadDataGroupBox.Controls.Add(payloadTemperatureTextBox);
            payloadDataGroupBox.Controls.Add(payloadHumidityLabel);
            payloadDataGroupBox.Controls.Add(payloadGPSAltitudeTextBox);
            payloadDataGroupBox.Controls.Add(payloadTemperatureLabel);
            payloadDataGroupBox.Controls.Add(payloadAltitudeTextBox);
            payloadDataGroupBox.Controls.Add(payloadLongtitudeLabel);
            payloadDataGroupBox.Controls.Add(payloadLatitudeLabel);
            payloadDataGroupBox.Controls.Add(payloadGPSAltitudeLabel);
            payloadDataGroupBox.Controls.Add(payloadAltitudeLabel);
            payloadDataGroupBox.Location = new Point(14, 289);
            payloadDataGroupBox.Name = "payloadDataGroupBox";
            payloadDataGroupBox.Size = new Size(1083, 221);
            payloadDataGroupBox.TabIndex = 1;
            payloadDataGroupBox.TabStop = false;
            payloadDataGroupBox.Text = "Payload Data";
            // 
            // payloadHumidityTextBox
            // 
            payloadHumidityTextBox.Font = new Font("Segoe UI", 14.25F);
            payloadHumidityTextBox.Location = new Point(557, 167);
            payloadHumidityTextBox.Name = "payloadHumidityTextBox";
            payloadHumidityTextBox.ReadOnly = true;
            payloadHumidityTextBox.Size = new Size(100, 33);
            payloadHumidityTextBox.TabIndex = 28;
            // 
            // payloadLongtitudeTextBox
            // 
            payloadLongtitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            payloadLongtitudeTextBox.Location = new Point(557, 107);
            payloadLongtitudeTextBox.Name = "payloadLongtitudeTextBox";
            payloadLongtitudeTextBox.ReadOnly = true;
            payloadLongtitudeTextBox.Size = new Size(100, 33);
            payloadLongtitudeTextBox.TabIndex = 27;
            // 
            // payloadLatitudeTextBox
            // 
            payloadLatitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            payloadLatitudeTextBox.Location = new Point(557, 44);
            payloadLatitudeTextBox.Name = "payloadLatitudeTextBox";
            payloadLatitudeTextBox.ReadOnly = true;
            payloadLatitudeTextBox.Size = new Size(100, 33);
            payloadLatitudeTextBox.TabIndex = 26;
            // 
            // payloadTemperatureTextBox
            // 
            payloadTemperatureTextBox.Font = new Font("Segoe UI", 14.25F);
            payloadTemperatureTextBox.Location = new Point(185, 167);
            payloadTemperatureTextBox.Name = "payloadTemperatureTextBox";
            payloadTemperatureTextBox.ReadOnly = true;
            payloadTemperatureTextBox.Size = new Size(100, 33);
            payloadTemperatureTextBox.TabIndex = 25;
            // 
            // payloadHumidityLabel
            // 
            payloadHumidityLabel.AutoSize = true;
            payloadHumidityLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payloadHumidityLabel.Location = new Point(388, 160);
            payloadHumidityLabel.Name = "payloadHumidityLabel";
            payloadHumidityLabel.Size = new Size(159, 32);
            payloadHumidityLabel.TabIndex = 14;
            payloadHumidityLabel.Text = "Humidity      :";
            // 
            // payloadGPSAltitudeTextBox
            // 
            payloadGPSAltitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            payloadGPSAltitudeTextBox.Location = new Point(185, 107);
            payloadGPSAltitudeTextBox.Name = "payloadGPSAltitudeTextBox";
            payloadGPSAltitudeTextBox.ReadOnly = true;
            payloadGPSAltitudeTextBox.Size = new Size(100, 33);
            payloadGPSAltitudeTextBox.TabIndex = 24;
            // 
            // payloadTemperatureLabel
            // 
            payloadTemperatureLabel.AutoSize = true;
            payloadTemperatureLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payloadTemperatureLabel.Location = new Point(20, 160);
            payloadTemperatureLabel.Name = "payloadTemperatureLabel";
            payloadTemperatureLabel.Size = new Size(161, 32);
            payloadTemperatureLabel.TabIndex = 12;
            payloadTemperatureLabel.Text = "Temperature :";
            // 
            // payloadAltitudeTextBox
            // 
            payloadAltitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            payloadAltitudeTextBox.Location = new Point(185, 44);
            payloadAltitudeTextBox.Name = "payloadAltitudeTextBox";
            payloadAltitudeTextBox.ReadOnly = true;
            payloadAltitudeTextBox.Size = new Size(100, 33);
            payloadAltitudeTextBox.TabIndex = 23;
            // 
            // payloadLongtitudeLabel
            // 
            payloadLongtitudeLabel.AutoSize = true;
            payloadLongtitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payloadLongtitudeLabel.Location = new Point(388, 103);
            payloadLongtitudeLabel.Name = "payloadLongtitudeLabel";
            payloadLongtitudeLabel.Size = new Size(163, 32);
            payloadLongtitudeLabel.TabIndex = 13;
            payloadLongtitudeLabel.Text = "Longtitude    :";
            // 
            // payloadLatitudeLabel
            // 
            payloadLatitudeLabel.AutoSize = true;
            payloadLatitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payloadLatitudeLabel.Location = new Point(388, 45);
            payloadLatitudeLabel.Name = "payloadLatitudeLabel";
            payloadLatitudeLabel.Size = new Size(161, 32);
            payloadLatitudeLabel.TabIndex = 12;
            payloadLatitudeLabel.Text = "Latitude        :";
            // 
            // payloadGPSAltitudeLabel
            // 
            payloadGPSAltitudeLabel.AutoSize = true;
            payloadGPSAltitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payloadGPSAltitudeLabel.Location = new Point(20, 103);
            payloadGPSAltitudeLabel.Name = "payloadGPSAltitudeLabel";
            payloadGPSAltitudeLabel.Size = new Size(159, 32);
            payloadGPSAltitudeLabel.TabIndex = 13;
            payloadGPSAltitudeLabel.Text = "GPS Altitude :";
            // 
            // payloadAltitudeLabel
            // 
            payloadAltitudeLabel.AutoSize = true;
            payloadAltitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            payloadAltitudeLabel.Location = new Point(20, 40);
            payloadAltitudeLabel.Name = "payloadAltitudeLabel";
            payloadAltitudeLabel.Size = new Size(159, 32);
            payloadAltitudeLabel.TabIndex = 12;
            payloadAltitudeLabel.Text = "Altitude        :";
            // 
            // mainDataGroupBox
            // 
            mainDataGroupBox.Controls.Add(panel2);
            mainDataGroupBox.Controls.Add(mainAccelZTextBox);
            mainDataGroupBox.Controls.Add(mainAccelYTextBox);
            mainDataGroupBox.Controls.Add(mainAccelXTextBox);
            mainDataGroupBox.Controls.Add(mainAngelTextBox);
            mainDataGroupBox.Controls.Add(mainGyroZTextBox);
            mainDataGroupBox.Controls.Add(mainGyroYTextBox);
            mainDataGroupBox.Controls.Add(mainGyroXTextBox);
            mainDataGroupBox.Controls.Add(mainLongtitudeTextBox);
            mainDataGroupBox.Controls.Add(mainLatitudeTextBox);
            mainDataGroupBox.Controls.Add(mainGPSAltitudeTextBox);
            mainDataGroupBox.Controls.Add(mainAltitudeTextBox);
            mainDataGroupBox.Controls.Add(panel1);
            mainDataGroupBox.Controls.Add(mainStateLabel);
            mainDataGroupBox.Controls.Add(mainAngelLabel);
            mainDataGroupBox.Controls.Add(mainAccelZLabel);
            mainDataGroupBox.Controls.Add(mainAccelYLabel);
            mainDataGroupBox.Controls.Add(mainAccelXLabel);
            mainDataGroupBox.Controls.Add(mainGPSAltitudeLabel);
            mainDataGroupBox.Controls.Add(mainLongtitudeLabel);
            mainDataGroupBox.Controls.Add(mainLaitudeLabel);
            mainDataGroupBox.Controls.Add(mainGyroZLabel);
            mainDataGroupBox.Controls.Add(mainGyroYLabel);
            mainDataGroupBox.Controls.Add(mainGyroXLabel);
            mainDataGroupBox.Controls.Add(mainAltitudeLabel);
            mainDataGroupBox.Location = new Point(14, 16);
            mainDataGroupBox.Name = "mainDataGroupBox";
            mainDataGroupBox.Size = new Size(1083, 259);
            mainDataGroupBox.TabIndex = 0;
            mainDataGroupBox.TabStop = false;
            mainDataGroupBox.Text = "Main Data";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(stage2Label);
            panel2.Location = new Point(920, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 32);
            panel2.TabIndex = 7;
            // 
            // stage2Label
            // 
            stage2Label.AutoSize = true;
            stage2Label.Location = new Point(25, 9);
            stage2Label.Name = "stage2Label";
            stage2Label.Size = new Size(49, 15);
            stage2Label.TabIndex = 8;
            stage2Label.Text = "STAGE 2";
            // 
            // mainAccelZTextBox
            // 
            mainAccelZTextBox.Font = new Font("Segoe UI", 14.25F);
            mainAccelZTextBox.Location = new Point(792, 149);
            mainAccelZTextBox.Name = "mainAccelZTextBox";
            mainAccelZTextBox.ReadOnly = true;
            mainAccelZTextBox.Size = new Size(100, 33);
            mainAccelZTextBox.TabIndex = 22;
            // 
            // mainAccelYTextBox
            // 
            mainAccelYTextBox.Font = new Font("Segoe UI", 14.25F);
            mainAccelYTextBox.Location = new Point(792, 98);
            mainAccelYTextBox.Name = "mainAccelYTextBox";
            mainAccelYTextBox.ReadOnly = true;
            mainAccelYTextBox.Size = new Size(100, 33);
            mainAccelYTextBox.TabIndex = 21;
            // 
            // mainAccelXTextBox
            // 
            mainAccelXTextBox.Font = new Font("Segoe UI", 14.25F);
            mainAccelXTextBox.Location = new Point(792, 41);
            mainAccelXTextBox.Name = "mainAccelXTextBox";
            mainAccelXTextBox.ReadOnly = true;
            mainAccelXTextBox.Size = new Size(100, 33);
            mainAccelXTextBox.TabIndex = 20;
            // 
            // mainAngelTextBox
            // 
            mainAngelTextBox.Font = new Font("Segoe UI", 14.25F);
            mainAngelTextBox.Location = new Point(493, 203);
            mainAngelTextBox.Name = "mainAngelTextBox";
            mainAngelTextBox.ReadOnly = true;
            mainAngelTextBox.Size = new Size(100, 33);
            mainAngelTextBox.TabIndex = 19;
            // 
            // mainGyroZTextBox
            // 
            mainGyroZTextBox.Font = new Font("Segoe UI", 14.25F);
            mainGyroZTextBox.Location = new Point(493, 152);
            mainGyroZTextBox.Name = "mainGyroZTextBox";
            mainGyroZTextBox.ReadOnly = true;
            mainGyroZTextBox.Size = new Size(100, 33);
            mainGyroZTextBox.TabIndex = 18;
            // 
            // mainGyroYTextBox
            // 
            mainGyroYTextBox.Font = new Font("Segoe UI", 14.25F);
            mainGyroYTextBox.Location = new Point(493, 101);
            mainGyroYTextBox.Name = "mainGyroYTextBox";
            mainGyroYTextBox.ReadOnly = true;
            mainGyroYTextBox.Size = new Size(100, 33);
            mainGyroYTextBox.TabIndex = 17;
            // 
            // mainGyroXTextBox
            // 
            mainGyroXTextBox.Font = new Font("Segoe UI", 14.25F);
            mainGyroXTextBox.Location = new Point(493, 44);
            mainGyroXTextBox.Name = "mainGyroXTextBox";
            mainGyroXTextBox.ReadOnly = true;
            mainGyroXTextBox.Size = new Size(100, 33);
            mainGyroXTextBox.TabIndex = 16;
            // 
            // mainLongtitudeTextBox
            // 
            mainLongtitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            mainLongtitudeTextBox.Location = new Point(185, 202);
            mainLongtitudeTextBox.Name = "mainLongtitudeTextBox";
            mainLongtitudeTextBox.ReadOnly = true;
            mainLongtitudeTextBox.Size = new Size(100, 33);
            mainLongtitudeTextBox.TabIndex = 15;
            // 
            // mainLatitudeTextBox
            // 
            mainLatitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            mainLatitudeTextBox.Location = new Point(185, 151);
            mainLatitudeTextBox.Name = "mainLatitudeTextBox";
            mainLatitudeTextBox.ReadOnly = true;
            mainLatitudeTextBox.Size = new Size(100, 33);
            mainLatitudeTextBox.TabIndex = 14;
            // 
            // mainGPSAltitudeTextBox
            // 
            mainGPSAltitudeTextBox.Font = new Font("Segoe UI", 14.25F);
            mainGPSAltitudeTextBox.Location = new Point(185, 100);
            mainGPSAltitudeTextBox.Name = "mainGPSAltitudeTextBox";
            mainGPSAltitudeTextBox.ReadOnly = true;
            mainGPSAltitudeTextBox.Size = new Size(100, 33);
            mainGPSAltitudeTextBox.TabIndex = 13;
            // 
            // mainAltitudeTextBox
            // 
            mainAltitudeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainAltitudeTextBox.Location = new Point(185, 45);
            mainAltitudeTextBox.Name = "mainAltitudeTextBox";
            mainAltitudeTextBox.ReadOnly = true;
            mainAltitudeTextBox.Size = new Size(100, 33);
            mainAltitudeTextBox.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(stage1Label);
            panel1.Location = new Point(792, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 32);
            panel1.TabIndex = 6;
            // 
            // stage1Label
            // 
            stage1Label.AutoSize = true;
            stage1Label.Location = new Point(25, 9);
            stage1Label.Name = "stage1Label";
            stage1Label.Size = new Size(49, 15);
            stage1Label.TabIndex = 7;
            stage1Label.Text = "STAGE 1";
            // 
            // mainStateLabel
            // 
            mainStateLabel.AutoSize = true;
            mainStateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainStateLabel.Location = new Point(674, 199);
            mainStateLabel.Name = "mainStateLabel";
            mainStateLabel.Size = new Size(67, 32);
            mainStateLabel.TabIndex = 11;
            mainStateLabel.Text = "State";
            // 
            // mainAngelLabel
            // 
            mainAngelLabel.AutoSize = true;
            mainAngelLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainAngelLabel.Location = new Point(390, 199);
            mainAngelLabel.Name = "mainAngelLabel";
            mainAngelLabel.Size = new Size(95, 32);
            mainAngelLabel.TabIndex = 10;
            mainAngelLabel.Text = "Angle  :";
            // 
            // mainAccelZLabel
            // 
            mainAccelZLabel.AutoSize = true;
            mainAccelZLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainAccelZLabel.Location = new Point(673, 150);
            mainAccelZLabel.Name = "mainAccelZLabel";
            mainAccelZLabel.Size = new Size(103, 32);
            mainAccelZLabel.TabIndex = 9;
            mainAccelZLabel.Text = "Accel Z :";
            // 
            // mainAccelYLabel
            // 
            mainAccelYLabel.AutoSize = true;
            mainAccelYLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainAccelYLabel.Location = new Point(673, 97);
            mainAccelYLabel.Name = "mainAccelYLabel";
            mainAccelYLabel.Size = new Size(102, 32);
            mainAccelYLabel.TabIndex = 8;
            mainAccelYLabel.Text = "Accel Y :";
            // 
            // mainAccelXLabel
            // 
            mainAccelXLabel.AutoSize = true;
            mainAccelXLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainAccelXLabel.Location = new Point(674, 40);
            mainAccelXLabel.Name = "mainAccelXLabel";
            mainAccelXLabel.Size = new Size(103, 32);
            mainAccelXLabel.TabIndex = 7;
            mainAccelXLabel.Text = "Accel X :";
            // 
            // mainGPSAltitudeLabel
            // 
            mainGPSAltitudeLabel.AutoSize = true;
            mainGPSAltitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainGPSAltitudeLabel.Location = new Point(20, 97);
            mainGPSAltitudeLabel.Name = "mainGPSAltitudeLabel";
            mainGPSAltitudeLabel.Size = new Size(159, 32);
            mainGPSAltitudeLabel.TabIndex = 6;
            mainGPSAltitudeLabel.Text = "GPS Altitude :";
            // 
            // mainLongtitudeLabel
            // 
            mainLongtitudeLabel.AutoSize = true;
            mainLongtitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainLongtitudeLabel.Location = new Point(20, 199);
            mainLongtitudeLabel.Name = "mainLongtitudeLabel";
            mainLongtitudeLabel.Size = new Size(163, 32);
            mainLongtitudeLabel.TabIndex = 5;
            mainLongtitudeLabel.Text = "Longtitude    :";
            // 
            // mainLaitudeLabel
            // 
            mainLaitudeLabel.AutoSize = true;
            mainLaitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainLaitudeLabel.Location = new Point(20, 150);
            mainLaitudeLabel.Name = "mainLaitudeLabel";
            mainLaitudeLabel.Size = new Size(161, 32);
            mainLaitudeLabel.TabIndex = 4;
            mainLaitudeLabel.Text = "Latitude        :";
            // 
            // mainGyroZLabel
            // 
            mainGyroZLabel.AutoSize = true;
            mainGyroZLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainGyroZLabel.Location = new Point(388, 150);
            mainGyroZLabel.Name = "mainGyroZLabel";
            mainGyroZLabel.Size = new Size(97, 32);
            mainGyroZLabel.TabIndex = 3;
            mainGyroZLabel.Text = "Gyro Z :";
            // 
            // mainGyroYLabel
            // 
            mainGyroYLabel.AutoSize = true;
            mainGyroYLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainGyroYLabel.Location = new Point(388, 97);
            mainGyroYLabel.Name = "mainGyroYLabel";
            mainGyroYLabel.Size = new Size(96, 32);
            mainGyroYLabel.TabIndex = 2;
            mainGyroYLabel.Text = "Gyro Y :";
            // 
            // mainGyroXLabel
            // 
            mainGyroXLabel.AutoSize = true;
            mainGyroXLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainGyroXLabel.Location = new Point(390, 40);
            mainGyroXLabel.Name = "mainGyroXLabel";
            mainGyroXLabel.Size = new Size(97, 32);
            mainGyroXLabel.TabIndex = 1;
            mainGyroXLabel.Text = "Gyro X :";
            // 
            // mainAltitudeLabel
            // 
            mainAltitudeLabel.AutoSize = true;
            mainAltitudeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mainAltitudeLabel.Location = new Point(20, 43);
            mainAltitudeLabel.Name = "mainAltitudeLabel";
            mainAltitudeLabel.Size = new Size(159, 32);
            mainAltitudeLabel.TabIndex = 0;
            mainAltitudeLabel.Text = "Altitude        :";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label24.Location = new Point(481, 9);
            label24.Name = "label24";
            label24.Size = new Size(411, 47);
            label24.TabIndex = 7;
            label24.Text = "TRAKYA ROKET TAKIMI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1344, 729);
            Controls.Add(label24);
            Controls.Add(dataPanel);
            Controls.Add(portPanel);
            Name = "Form1";
            Text = "Trakya Roket Takımı Yer İstasyonu";
            Load += Form1_Load;
            portPanel.ResumeLayout(false);
            hyiPortGroupBox.ResumeLayout(false);
            hyiPortGroupBox.PerformLayout();
            payloadPortGroupBox.ResumeLayout(false);
            payloadPortGroupBox.PerformLayout();
            mainPortGroupBox.ResumeLayout(false);
            mainPortGroupBox.PerformLayout();
            dataPanel.ResumeLayout(false);
            payloadDataGroupBox.ResumeLayout(false);
            payloadDataGroupBox.PerformLayout();
            mainDataGroupBox.ResumeLayout(false);
            mainDataGroupBox.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel portPanel;
        private GroupBox mainPortGroupBox;
        private Panel dataPanel;
        private Label mainComPortLabel;
        private Label mainBaudRateLabel;
        private ComboBox mainPortComboBox;
        private GroupBox hyiPortGroupBox;
        private Panel hyiPortActivePanel;
        private Button hyiPortButton;
        private ComboBox hyiBaudRateComboBox;
        private Label hyiComPortLabel;
        private Label hyiBaudRateLabel;
        private ComboBox hyiPortComboBox;
        private GroupBox payloadPortGroupBox;
        private Panel payloadPortActivePanel;
        private Button payloadPortButton;
        private ComboBox payloadBaudRateComboBox;
        private Label payloadComPortLabel;
        private Label payloadBaudRateLabel;
        private ComboBox payloadPortComboBox;
        private Panel mainPortActivePanel;
        private Button mainPortButton;
        private ComboBox mainBaudRateComboBox;
        private GroupBox payloadDataGroupBox;
        private GroupBox mainDataGroupBox;
        private Label mainGPSAltitudeLabel;
        private Label mainLongtitudeLabel;
        private Label mainLaitudeLabel;
        private Label mainGyroZLabel;
        private Label mainGyroYLabel;
        private Label mainGyroXLabel;
        private Label mainAltitudeLabel;
        private Label mainAngelLabel;
        private Label mainAccelZLabel;
        private Label mainAccelYLabel;
        private Label mainAccelXLabel;
        private Label mainStateLabel;
        private Label payloadLongtitudeLabel;
        private Label payloadLatitudeLabel;
        private Label payloadGPSAltitudeLabel;
        private Label payloadAltitudeLabel;
        private Label payloadHumidityLabel;
        private Label payloadTemperatureLabel;
        private Panel panel1;
        private TextBox mainAltitudeTextBox;
        private TextBox payloadHumidityTextBox;
        private TextBox payloadLongtitudeTextBox;
        private TextBox payloadLatitudeTextBox;
        private TextBox payloadTemperatureTextBox;
        private TextBox payloadGPSAltitudeTextBox;
        private TextBox payloadAltitudeTextBox;
        private TextBox mainAccelZTextBox;
        private TextBox mainAccelYTextBox;
        private TextBox mainAccelXTextBox;
        private TextBox mainAngelTextBox;
        private TextBox mainGyroZTextBox;
        private TextBox mainGyroYTextBox;
        private TextBox mainGyroXTextBox;
        private TextBox mainLongtitudeTextBox;
        private TextBox mainLatitudeTextBox;
        private TextBox mainGPSAltitudeTextBox;
        private Label stage1Label;
        private Panel panel2;
        private Label stage2Label;
        private Label label24;
    }
}
