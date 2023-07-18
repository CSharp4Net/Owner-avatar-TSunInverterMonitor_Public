namespace NZZ.TSIM.WinApp
{
  partial class FormMain
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      PnFooter = new Panel();
      LbLog = new ListBox();
      PnHeader = new Panel();
      BtnOpenWorkFolder = new Button();
      BtnDebug = new Button();
      TbServicePassword = new TextBox();
      label2 = new Label();
      TbServiceUserName = new TextBox();
      label1 = new Label();
      BtnOpenSettings = new Button();
      BtnConnect = new Button();
      PnBody = new Panel();
      ChHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
      panel2 = new Panel();
      label5 = new Label();
      BtnDayAfter = new Button();
      BtnDayBefore = new Button();
      DpHistoryDate = new DateTimePicker();
      label16 = new Label();
      LbHistoryTotal = new Label();
      CbHistoryType = new ComboBox();
      panel1 = new Panel();
      LbStationInstalledCapacity = new Label();
      label17 = new Label();
      LbStationTimeZone = new Label();
      label15 = new Label();
      LbStationTotalEnergy = new Label();
      LbStationTodayPeakPower = new Label();
      LbStationCurrentYearEnergy = new Label();
      LbStationTimeStamp = new Label();
      LbStationCurrentMonthEnergy = new Label();
      LbStationAddress = new Label();
      LbStationCurrentDayEnergy = new Label();
      LbStationActivePower = new Label();
      label12 = new Label();
      label14 = new Label();
      label10 = new Label();
      label9 = new Label();
      BtnDisconnect = new Button();
      LbStationGuid = new Label();
      label7 = new Label();
      label13 = new Label();
      label4 = new Label();
      label6 = new Label();
      label11 = new Label();
      BtnRefresh = new Button();
      CbStations = new ComboBox();
      label8 = new Label();
      PnFooter.SuspendLayout();
      PnHeader.SuspendLayout();
      PnBody.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)ChHistory).BeginInit();
      panel2.SuspendLayout();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // PnFooter
      // 
      PnFooter.BorderStyle = BorderStyle.FixedSingle;
      PnFooter.Controls.Add(LbLog);
      PnFooter.Dock = DockStyle.Bottom;
      PnFooter.Location = new Point(0, 648);
      PnFooter.Name = "PnFooter";
      PnFooter.Size = new Size(1184, 113);
      PnFooter.TabIndex = 1;
      // 
      // LbLog
      // 
      LbLog.Dock = DockStyle.Fill;
      LbLog.FormattingEnabled = true;
      LbLog.ItemHeight = 17;
      LbLog.Location = new Point(0, 0);
      LbLog.Name = "LbLog";
      LbLog.ScrollAlwaysVisible = true;
      LbLog.Size = new Size(1182, 111);
      LbLog.TabIndex = 0;
      // 
      // PnHeader
      // 
      PnHeader.BorderStyle = BorderStyle.FixedSingle;
      PnHeader.Controls.Add(BtnOpenWorkFolder);
      PnHeader.Controls.Add(BtnDebug);
      PnHeader.Controls.Add(TbServicePassword);
      PnHeader.Controls.Add(label2);
      PnHeader.Controls.Add(TbServiceUserName);
      PnHeader.Controls.Add(label1);
      PnHeader.Controls.Add(BtnOpenSettings);
      PnHeader.Controls.Add(BtnConnect);
      PnHeader.Dock = DockStyle.Top;
      PnHeader.Location = new Point(0, 0);
      PnHeader.Name = "PnHeader";
      PnHeader.Size = new Size(1184, 80);
      PnHeader.TabIndex = 2;
      // 
      // BtnOpenWorkFolder
      // 
      BtnOpenWorkFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnOpenWorkFolder.Location = new Point(1021, 42);
      BtnOpenWorkFolder.Name = "BtnOpenWorkFolder";
      BtnOpenWorkFolder.Size = new Size(150, 25);
      BtnOpenWorkFolder.TabIndex = 7;
      BtnOpenWorkFolder.Text = "Arbeitsverzeichnis";
      BtnOpenWorkFolder.UseVisualStyleBackColor = true;
      BtnOpenWorkFolder.Click += BtnOpenWorkFolder_Click;
      // 
      // BtnDebug
      // 
      BtnDebug.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnDebug.Location = new Point(915, 11);
      BtnDebug.Name = "BtnDebug";
      BtnDebug.Size = new Size(100, 56);
      BtnDebug.TabIndex = 6;
      BtnDebug.Text = "DEBUG";
      BtnDebug.UseVisualStyleBackColor = true;
      BtnDebug.Click += BtnDebug_Click;
      // 
      // TbServicePassword
      // 
      TbServicePassword.Location = new Point(80, 42);
      TbServicePassword.Name = "TbServicePassword";
      TbServicePassword.PasswordChar = '*';
      TbServicePassword.PlaceholderText = "T-SUN Kennwort";
      TbServicePassword.Size = new Size(200, 25);
      TbServicePassword.TabIndex = 4;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(11, 45);
      label2.Name = "label2";
      label2.Size = new Size(63, 17);
      label2.TabIndex = 3;
      label2.Text = "Kennwort";
      // 
      // TbServiceUserName
      // 
      TbServiceUserName.Location = new Point(80, 11);
      TbServiceUserName.Name = "TbServiceUserName";
      TbServiceUserName.PlaceholderText = "T-SUN Benutzername";
      TbServiceUserName.Size = new Size(200, 25);
      TbServiceUserName.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(29, 14);
      label1.Name = "label1";
      label1.Size = new Size(45, 17);
      label1.TabIndex = 1;
      label1.Text = "E-Mail";
      // 
      // BtnOpenSettings
      // 
      BtnOpenSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnOpenSettings.Location = new Point(1021, 11);
      BtnOpenSettings.Name = "BtnOpenSettings";
      BtnOpenSettings.Size = new Size(150, 25);
      BtnOpenSettings.TabIndex = 0;
      BtnOpenSettings.Text = "Einstellungen";
      BtnOpenSettings.UseVisualStyleBackColor = true;
      BtnOpenSettings.Click += BtnOpenSettings_Click;
      // 
      // BtnConnect
      // 
      BtnConnect.Location = new Point(286, 11);
      BtnConnect.Name = "BtnConnect";
      BtnConnect.Size = new Size(100, 56);
      BtnConnect.TabIndex = 5;
      BtnConnect.Text = "Verbinden";
      BtnConnect.UseVisualStyleBackColor = true;
      BtnConnect.Click += BtnConnect_Click;
      // 
      // PnBody
      // 
      PnBody.Controls.Add(ChHistory);
      PnBody.Controls.Add(panel2);
      PnBody.Controls.Add(panel1);
      PnBody.Dock = DockStyle.Fill;
      PnBody.Location = new Point(0, 80);
      PnBody.Name = "PnBody";
      PnBody.Size = new Size(1184, 568);
      PnBody.TabIndex = 3;
      PnBody.Visible = false;
      // 
      // ChHistory
      // 
      chartArea1.Name = "ChartArea1";
      ChHistory.ChartAreas.Add(chartArea1);
      ChHistory.Dock = DockStyle.Fill;
      ChHistory.Location = new Point(0, 145);
      ChHistory.Name = "ChHistory";
      series1.ChartArea = "ChartArea1";
      series1.Name = "Series1";
      ChHistory.Series.Add(series1);
      ChHistory.Size = new Size(1184, 423);
      ChHistory.TabIndex = 15;
      // 
      // panel2
      // 
      panel2.Controls.Add(label5);
      panel2.Controls.Add(BtnDayAfter);
      panel2.Controls.Add(BtnDayBefore);
      panel2.Controls.Add(DpHistoryDate);
      panel2.Controls.Add(label16);
      panel2.Controls.Add(LbHistoryTotal);
      panel2.Controls.Add(CbHistoryType);
      panel2.Dock = DockStyle.Top;
      panel2.Location = new Point(0, 110);
      panel2.Name = "panel2";
      panel2.Size = new Size(1184, 35);
      panel2.TabIndex = 14;
      // 
      // label5
      // 
      label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
      label5.Location = new Point(13, 10);
      label5.Margin = new Padding(3);
      label5.Name = "label5";
      label5.Size = new Size(80, 17);
      label5.TabIndex = 20;
      label5.Text = "Historie:";
      label5.TextAlign = ContentAlignment.TopRight;
      // 
      // BtnDayAfter
      // 
      BtnDayAfter.Location = new Point(620, 6);
      BtnDayAfter.Name = "BtnDayAfter";
      BtnDayAfter.Size = new Size(25, 25);
      BtnDayAfter.TabIndex = 13;
      BtnDayAfter.Text = ">";
      BtnDayAfter.UseVisualStyleBackColor = true;
      BtnDayAfter.Click += BtnDayAfter_Click;
      // 
      // BtnDayBefore
      // 
      BtnDayBefore.Location = new Point(434, 6);
      BtnDayBefore.Name = "BtnDayBefore";
      BtnDayBefore.Size = new Size(25, 25);
      BtnDayBefore.TabIndex = 12;
      BtnDayBefore.Text = "<";
      BtnDayBefore.UseVisualStyleBackColor = true;
      BtnDayBefore.Click += BtnDayBefore_Click;
      // 
      // DpHistoryDate
      // 
      DpHistoryDate.CustomFormat = "yyyy";
      DpHistoryDate.Format = DateTimePickerFormat.Custom;
      DpHistoryDate.Location = new Point(465, 6);
      DpHistoryDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      DpHistoryDate.Name = "DpHistoryDate";
      DpHistoryDate.Size = new Size(150, 25);
      DpHistoryDate.TabIndex = 4;
      DpHistoryDate.ValueChanged += DpHistoryDate_ValueChanged;
      // 
      // label16
      // 
      label16.Location = new Point(761, 10);
      label16.Margin = new Padding(3);
      label16.Name = "label16";
      label16.Size = new Size(100, 17);
      label16.TabIndex = 11;
      label16.Text = "Gesamt:";
      label16.TextAlign = ContentAlignment.TopRight;
      // 
      // LbHistoryTotal
      // 
      LbHistoryTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      LbHistoryTotal.Location = new Point(867, 12);
      LbHistoryTotal.Margin = new Padding(3);
      LbHistoryTotal.Name = "LbHistoryTotal";
      LbHistoryTotal.Size = new Size(100, 17);
      LbHistoryTotal.TabIndex = 10;
      LbHistoryTotal.Text = "...";
      LbHistoryTotal.TextAlign = ContentAlignment.TopRight;
      // 
      // CbHistoryType
      // 
      CbHistoryType.DropDownStyle = ComboBoxStyle.DropDownList;
      CbHistoryType.FormattingEnabled = true;
      CbHistoryType.Location = new Point(99, 6);
      CbHistoryType.Name = "CbHistoryType";
      CbHistoryType.Size = new Size(150, 25);
      CbHistoryType.TabIndex = 1;
      CbHistoryType.SelectedIndexChanged += CbHistoryType_SelectedIndexChanged;
      // 
      // panel1
      // 
      panel1.BorderStyle = BorderStyle.FixedSingle;
      panel1.Controls.Add(LbStationInstalledCapacity);
      panel1.Controls.Add(label17);
      panel1.Controls.Add(LbStationTimeZone);
      panel1.Controls.Add(label15);
      panel1.Controls.Add(LbStationTotalEnergy);
      panel1.Controls.Add(LbStationTodayPeakPower);
      panel1.Controls.Add(LbStationCurrentYearEnergy);
      panel1.Controls.Add(LbStationTimeStamp);
      panel1.Controls.Add(LbStationCurrentMonthEnergy);
      panel1.Controls.Add(LbStationAddress);
      panel1.Controls.Add(LbStationCurrentDayEnergy);
      panel1.Controls.Add(LbStationActivePower);
      panel1.Controls.Add(label12);
      panel1.Controls.Add(label14);
      panel1.Controls.Add(label10);
      panel1.Controls.Add(label9);
      panel1.Controls.Add(BtnDisconnect);
      panel1.Controls.Add(LbStationGuid);
      panel1.Controls.Add(label7);
      panel1.Controls.Add(label13);
      panel1.Controls.Add(label4);
      panel1.Controls.Add(label6);
      panel1.Controls.Add(label11);
      panel1.Controls.Add(BtnRefresh);
      panel1.Controls.Add(CbStations);
      panel1.Controls.Add(label8);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1184, 110);
      panel1.TabIndex = 9;
      // 
      // LbStationInstalledCapacity
      // 
      LbStationInstalledCapacity.AutoSize = true;
      LbStationInstalledCapacity.Location = new Point(620, 38);
      LbStationInstalledCapacity.Margin = new Padding(3);
      LbStationInstalledCapacity.Name = "LbStationInstalledCapacity";
      LbStationInstalledCapacity.Size = new Size(17, 17);
      LbStationInstalledCapacity.TabIndex = 23;
      LbStationInstalledCapacity.Text = "...";
      // 
      // label17
      // 
      label17.Location = new Point(464, 38);
      label17.Margin = new Padding(3);
      label17.Name = "label17";
      label17.Size = new Size(150, 17);
      label17.TabIndex = 22;
      label17.Text = "Maximale Leistung:";
      label17.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationTimeZone
      // 
      LbStationTimeZone.AutoSize = true;
      LbStationTimeZone.Location = new Point(98, 84);
      LbStationTimeZone.Margin = new Padding(3);
      LbStationTimeZone.Name = "LbStationTimeZone";
      LbStationTimeZone.Size = new Size(17, 17);
      LbStationTimeZone.TabIndex = 21;
      LbStationTimeZone.Text = "...";
      // 
      // label15
      // 
      label15.Location = new Point(12, 84);
      label15.Margin = new Padding(3);
      label15.Name = "label15";
      label15.Size = new Size(80, 17);
      label15.TabIndex = 20;
      label15.Text = "Zeitzone:";
      label15.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationTotalEnergy
      // 
      LbStationTotalEnergy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      LbStationTotalEnergy.Location = new Point(867, 81);
      LbStationTotalEnergy.Margin = new Padding(3);
      LbStationTotalEnergy.Name = "LbStationTotalEnergy";
      LbStationTotalEnergy.Size = new Size(100, 17);
      LbStationTotalEnergy.TabIndex = 16;
      LbStationTotalEnergy.Text = "...";
      LbStationTotalEnergy.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationTodayPeakPower
      // 
      LbStationTodayPeakPower.AutoSize = true;
      LbStationTodayPeakPower.Location = new Point(619, 61);
      LbStationTodayPeakPower.Margin = new Padding(3);
      LbStationTodayPeakPower.Name = "LbStationTodayPeakPower";
      LbStationTodayPeakPower.Size = new Size(17, 17);
      LbStationTodayPeakPower.TabIndex = 17;
      LbStationTodayPeakPower.Text = "...";
      // 
      // LbStationCurrentYearEnergy
      // 
      LbStationCurrentYearEnergy.Location = new Point(867, 56);
      LbStationCurrentYearEnergy.Margin = new Padding(3);
      LbStationCurrentYearEnergy.Name = "LbStationCurrentYearEnergy";
      LbStationCurrentYearEnergy.Size = new Size(100, 17);
      LbStationCurrentYearEnergy.TabIndex = 10;
      LbStationCurrentYearEnergy.Text = "...";
      LbStationCurrentYearEnergy.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationTimeStamp
      // 
      LbStationTimeStamp.AutoSize = true;
      LbStationTimeStamp.Location = new Point(620, 12);
      LbStationTimeStamp.Margin = new Padding(3);
      LbStationTimeStamp.Name = "LbStationTimeStamp";
      LbStationTimeStamp.Size = new Size(17, 17);
      LbStationTimeStamp.TabIndex = 19;
      LbStationTimeStamp.Text = "...";
      // 
      // LbStationCurrentMonthEnergy
      // 
      LbStationCurrentMonthEnergy.Location = new Point(867, 33);
      LbStationCurrentMonthEnergy.Margin = new Padding(3);
      LbStationCurrentMonthEnergy.Name = "LbStationCurrentMonthEnergy";
      LbStationCurrentMonthEnergy.Size = new Size(100, 17);
      LbStationCurrentMonthEnergy.TabIndex = 8;
      LbStationCurrentMonthEnergy.Text = "...";
      LbStationCurrentMonthEnergy.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationAddress
      // 
      LbStationAddress.AutoSize = true;
      LbStationAddress.Location = new Point(98, 61);
      LbStationAddress.Margin = new Padding(3);
      LbStationAddress.Name = "LbStationAddress";
      LbStationAddress.Size = new Size(17, 17);
      LbStationAddress.TabIndex = 6;
      LbStationAddress.Text = "...";
      // 
      // LbStationCurrentDayEnergy
      // 
      LbStationCurrentDayEnergy.Location = new Point(867, 12);
      LbStationCurrentDayEnergy.Margin = new Padding(3);
      LbStationCurrentDayEnergy.Name = "LbStationCurrentDayEnergy";
      LbStationCurrentDayEnergy.Size = new Size(100, 17);
      LbStationCurrentDayEnergy.TabIndex = 7;
      LbStationCurrentDayEnergy.Text = "...";
      LbStationCurrentDayEnergy.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationActivePower
      // 
      LbStationActivePower.AutoSize = true;
      LbStationActivePower.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      LbStationActivePower.Location = new Point(620, 86);
      LbStationActivePower.Margin = new Padding(3);
      LbStationActivePower.Name = "LbStationActivePower";
      LbStationActivePower.Size = new Size(16, 15);
      LbStationActivePower.TabIndex = 12;
      LbStationActivePower.Text = "...";
      // 
      // label12
      // 
      label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      label12.Location = new Point(711, 79);
      label12.Margin = new Padding(3);
      label12.Name = "label12";
      label12.Size = new Size(150, 17);
      label12.TabIndex = 15;
      label12.Text = "Insgesamt:";
      label12.TextAlign = ContentAlignment.TopRight;
      // 
      // label14
      // 
      label14.Location = new Point(534, 12);
      label14.Margin = new Padding(3);
      label14.Name = "label14";
      label14.Size = new Size(80, 17);
      label14.TabIndex = 18;
      label14.Text = "Aktualisiert:";
      label14.TextAlign = ContentAlignment.TopRight;
      // 
      // label10
      // 
      label10.Location = new Point(464, 61);
      label10.Margin = new Padding(3);
      label10.Name = "label10";
      label10.Size = new Size(150, 17);
      label10.TabIndex = 14;
      label10.Text = "Heutiger Spitzenwert:";
      label10.TextAlign = ContentAlignment.TopRight;
      // 
      // label9
      // 
      label9.Location = new Point(711, 56);
      label9.Margin = new Padding(3);
      label9.Name = "label9";
      label9.Size = new Size(150, 17);
      label9.TabIndex = 13;
      label9.Text = "Jahr gesamt:";
      label9.TextAlign = ContentAlignment.TopRight;
      // 
      // BtnDisconnect
      // 
      BtnDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnDisconnect.Location = new Point(1020, 38);
      BtnDisconnect.Name = "BtnDisconnect";
      BtnDisconnect.Size = new Size(150, 25);
      BtnDisconnect.TabIndex = 6;
      BtnDisconnect.Text = "Trennen";
      BtnDisconnect.UseVisualStyleBackColor = true;
      BtnDisconnect.Click += BtnDisconnect_Click;
      // 
      // LbStationGuid
      // 
      LbStationGuid.AutoSize = true;
      LbStationGuid.Location = new Point(98, 38);
      LbStationGuid.Margin = new Padding(3);
      LbStationGuid.Name = "LbStationGuid";
      LbStationGuid.Size = new Size(17, 17);
      LbStationGuid.TabIndex = 4;
      LbStationGuid.Text = "...";
      // 
      // label7
      // 
      label7.Location = new Point(12, 61);
      label7.Margin = new Padding(3);
      label7.Name = "label7";
      label7.Size = new Size(80, 17);
      label7.TabIndex = 5;
      label7.Text = "Adresse:";
      label7.TextAlign = ContentAlignment.TopRight;
      // 
      // label13
      // 
      label13.Location = new Point(711, 33);
      label13.Margin = new Padding(3);
      label13.Name = "label13";
      label13.Size = new Size(150, 17);
      label13.TabIndex = 11;
      label13.Text = "Monat gesamt:";
      label13.TextAlign = ContentAlignment.TopRight;
      // 
      // label4
      // 
      label4.Location = new Point(12, 12);
      label4.Margin = new Padding(3);
      label4.Name = "label4";
      label4.Size = new Size(80, 17);
      label4.TabIndex = 5;
      label4.Text = "Station:";
      label4.TextAlign = ContentAlignment.TopRight;
      // 
      // label6
      // 
      label6.Location = new Point(12, 38);
      label6.Margin = new Padding(3);
      label6.Name = "label6";
      label6.Size = new Size(80, 17);
      label6.TabIndex = 3;
      label6.Text = "Guid:";
      label6.TextAlign = ContentAlignment.TopRight;
      // 
      // label11
      // 
      label11.Location = new Point(711, 12);
      label11.Margin = new Padding(3);
      label11.Name = "label11";
      label11.Size = new Size(150, 17);
      label11.TabIndex = 9;
      label11.Text = "Heute gesamt:";
      label11.TextAlign = ContentAlignment.TopRight;
      // 
      // BtnRefresh
      // 
      BtnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnRefresh.Location = new Point(1020, 7);
      BtnRefresh.Name = "BtnRefresh";
      BtnRefresh.Size = new Size(150, 25);
      BtnRefresh.TabIndex = 8;
      BtnRefresh.Text = "Aktualisieren";
      BtnRefresh.UseVisualStyleBackColor = true;
      BtnRefresh.Click += BtnRefresh_Click;
      // 
      // CbStations
      // 
      CbStations.DropDownStyle = ComboBoxStyle.DropDownList;
      CbStations.FormattingEnabled = true;
      CbStations.Location = new Point(98, 7);
      CbStations.Name = "CbStations";
      CbStations.Size = new Size(300, 25);
      CbStations.TabIndex = 7;
      CbStations.SelectedIndexChanged += CbStations_SelectedIndexChanged;
      // 
      // label8
      // 
      label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
      label8.Location = new Point(464, 84);
      label8.Margin = new Padding(3);
      label8.Name = "label8";
      label8.Size = new Size(150, 17);
      label8.TabIndex = 7;
      label8.Text = "Aktuelle Leistung:";
      label8.TextAlign = ContentAlignment.TopRight;
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 17F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1184, 761);
      Controls.Add(PnBody);
      Controls.Add(PnHeader);
      Controls.Add(PnFooter);
      Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
      Icon = (Icon)resources.GetObject("$this.Icon");
      Name = "FormMain";
      StartPosition = FormStartPosition.CenterScreen;
      Tag = "TSunInverterMonitor - {0}";
      Text = "TSunInverterMonitor - Nicht verbunden";
      FormClosing += FormMain_FormClosing;
      PnFooter.ResumeLayout(false);
      PnHeader.ResumeLayout(false);
      PnHeader.PerformLayout();
      PnBody.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)ChHistory).EndInit();
      panel2.ResumeLayout(false);
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private Panel PnFooter;
    private Panel PnHeader;
    private Button BtnOpenSettings;
    private Panel PnBody;
    private TextBox TbServicePassword;
    private Label label2;
    private TextBox TbServiceUserName;
    private Label label1;
    private Button BtnConnect;
    private ListBox LbLog;
    private ComboBox CbStations;
    private Label label4;
    private Button BtnRefresh;
    private Button BtnDisconnect;
    private Button BtnDebug;
    private Label LbStationTimeStamp;
    private Label label14;
    private Label LbStationTodayPeakPower;
    private Label LbStationTotalEnergy;
    private Label label12;
    private Label label10;
    private Label label9;
    private Label LbStationActivePower;
    private Label LbStationCurrentYearEnergy;
    private Label label13;
    private Label LbStationCurrentMonthEnergy;
    private Label label11;
    private Label LbStationCurrentDayEnergy;
    private Label label8;
    private Label LbStationAddress;
    private Label label7;
    private Label label6;
    private Label LbStationGuid;
    private Panel panel1;
    private System.Windows.Forms.DataVisualization.Charting.Chart ChHistory;
    private Panel panel2;
    private Button BtnDayAfter;
    private Button BtnDayBefore;
    private DateTimePicker DpHistoryDate;
    private Label label16;
    private Label LbHistoryTotal;
    private ComboBox CbHistoryType;
    private Label label5;
    private Button BtnOpenWorkFolder;
    private Label LbStationInstalledCapacity;
    private Label label17;
    private Label LbStationTimeZone;
    private Label label15;
  }
}