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
      PnFooter = new Panel();
      LbLog = new ListBox();
      PnHeader = new Panel();
      TbServicePassword = new TextBox();
      label2 = new Label();
      TbServiceUserName = new TextBox();
      label1 = new Label();
      BtnOpenSettings = new Button();
      BtnConnect = new Button();
      PnBody = new Panel();
      tabControl1 = new TabControl();
      tabPage2 = new TabPage();
      groupBox2 = new GroupBox();
      LbStationTimeStamp = new Label();
      label14 = new Label();
      LbStationTodayPeakPower = new Label();
      LbStationTotalEnergy = new Label();
      label12 = new Label();
      label10 = new Label();
      label9 = new Label();
      LbStationActivePower = new Label();
      LbStationCurrentYearEnergy = new Label();
      label13 = new Label();
      LbStationCurrentMonthEnergy = new Label();
      label11 = new Label();
      LbStationCurrentDayEnergy = new Label();
      label8 = new Label();
      groupBox1 = new GroupBox();
      label5 = new Label();
      LbStationAddress = new Label();
      LbStationId = new Label();
      label7 = new Label();
      label6 = new Label();
      LbStationGuid = new Label();
      tabPage4 = new TabPage();
      CbHistoryType = new ComboBox();
      label3 = new Label();
      BtnDisconnect = new Button();
      BtnRefresh = new Button();
      CbStations = new ComboBox();
      label4 = new Label();
      PnFooter.SuspendLayout();
      PnHeader.SuspendLayout();
      PnBody.SuspendLayout();
      tabControl1.SuspendLayout();
      tabPage2.SuspendLayout();
      groupBox2.SuspendLayout();
      groupBox1.SuspendLayout();
      tabPage4.SuspendLayout();
      SuspendLayout();
      // 
      // PnFooter
      // 
      PnFooter.BorderStyle = BorderStyle.FixedSingle;
      PnFooter.Controls.Add(LbLog);
      PnFooter.Dock = DockStyle.Bottom;
      PnFooter.Location = new Point(0, 461);
      PnFooter.Name = "PnFooter";
      PnFooter.Size = new Size(784, 100);
      PnFooter.TabIndex = 1;
      // 
      // LbLog
      // 
      LbLog.Dock = DockStyle.Fill;
      LbLog.FormattingEnabled = true;
      LbLog.ItemHeight = 15;
      LbLog.Location = new Point(0, 0);
      LbLog.Name = "LbLog";
      LbLog.ScrollAlwaysVisible = true;
      LbLog.Size = new Size(782, 98);
      LbLog.TabIndex = 0;
      // 
      // PnHeader
      // 
      PnHeader.BorderStyle = BorderStyle.FixedSingle;
      PnHeader.Controls.Add(TbServicePassword);
      PnHeader.Controls.Add(label2);
      PnHeader.Controls.Add(TbServiceUserName);
      PnHeader.Controls.Add(label1);
      PnHeader.Controls.Add(BtnOpenSettings);
      PnHeader.Controls.Add(BtnConnect);
      PnHeader.Dock = DockStyle.Top;
      PnHeader.Location = new Point(0, 0);
      PnHeader.Name = "PnHeader";
      PnHeader.Size = new Size(784, 50);
      PnHeader.TabIndex = 2;
      // 
      // TbServicePassword
      // 
      TbServicePassword.Location = new Point(296, 16);
      TbServicePassword.Name = "TbServicePassword";
      TbServicePassword.PasswordChar = '*';
      TbServicePassword.PlaceholderText = "T-SUN Kennwort";
      TbServicePassword.Size = new Size(100, 23);
      TbServicePassword.TabIndex = 4;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(232, 19);
      label2.Name = "label2";
      label2.Size = new Size(58, 15);
      label2.TabIndex = 3;
      label2.Text = "Kennwort";
      // 
      // TbServiceUserName
      // 
      TbServiceUserName.Location = new Point(62, 16);
      TbServiceUserName.Name = "TbServiceUserName";
      TbServiceUserName.PlaceholderText = "T-SUN Benutzername";
      TbServiceUserName.Size = new Size(150, 23);
      TbServiceUserName.TabIndex = 2;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(12, 19);
      label1.Name = "label1";
      label1.Size = new Size(41, 15);
      label1.TabIndex = 1;
      label1.Text = "E-Mail";
      // 
      // BtnOpenSettings
      // 
      BtnOpenSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnOpenSettings.Location = new Point(671, 11);
      BtnOpenSettings.Name = "BtnOpenSettings";
      BtnOpenSettings.Size = new Size(100, 30);
      BtnOpenSettings.TabIndex = 0;
      BtnOpenSettings.Text = "Einstellungen";
      BtnOpenSettings.UseVisualStyleBackColor = true;
      BtnOpenSettings.Click += BtnOpenSettings_Click;
      // 
      // BtnConnect
      // 
      BtnConnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnConnect.Location = new Point(565, 11);
      BtnConnect.Name = "BtnConnect";
      BtnConnect.Size = new Size(100, 30);
      BtnConnect.TabIndex = 5;
      BtnConnect.Text = "Verbinden";
      BtnConnect.UseVisualStyleBackColor = true;
      BtnConnect.Click += BtnConnect_Click;
      // 
      // PnBody
      // 
      PnBody.Controls.Add(tabControl1);
      PnBody.Controls.Add(BtnDisconnect);
      PnBody.Controls.Add(BtnRefresh);
      PnBody.Controls.Add(CbStations);
      PnBody.Controls.Add(label4);
      PnBody.Dock = DockStyle.Fill;
      PnBody.Location = new Point(0, 50);
      PnBody.Name = "PnBody";
      PnBody.Size = new Size(784, 411);
      PnBody.TabIndex = 3;
      PnBody.Visible = false;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Controls.Add(tabPage4);
      tabControl1.Location = new Point(3, 42);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(778, 363);
      tabControl1.TabIndex = 9;
      // 
      // tabPage2
      // 
      tabPage2.Controls.Add(groupBox2);
      tabPage2.Controls.Add(groupBox1);
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(770, 335);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "Details";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(LbStationTimeStamp);
      groupBox2.Controls.Add(label14);
      groupBox2.Controls.Add(LbStationTodayPeakPower);
      groupBox2.Controls.Add(LbStationTotalEnergy);
      groupBox2.Controls.Add(label12);
      groupBox2.Controls.Add(label10);
      groupBox2.Controls.Add(label9);
      groupBox2.Controls.Add(LbStationActivePower);
      groupBox2.Controls.Add(LbStationCurrentYearEnergy);
      groupBox2.Controls.Add(label13);
      groupBox2.Controls.Add(LbStationCurrentMonthEnergy);
      groupBox2.Controls.Add(label11);
      groupBox2.Controls.Add(LbStationCurrentDayEnergy);
      groupBox2.Controls.Add(label8);
      groupBox2.Location = new Point(6, 82);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(758, 116);
      groupBox2.TabIndex = 8;
      groupBox2.TabStop = false;
      groupBox2.Text = "Werte";
      // 
      // LbStationTimeStamp
      // 
      LbStationTimeStamp.AutoSize = true;
      LbStationTimeStamp.Location = new Point(162, 22);
      LbStationTimeStamp.Margin = new Padding(3);
      LbStationTimeStamp.Name = "LbStationTimeStamp";
      LbStationTimeStamp.Size = new Size(16, 15);
      LbStationTimeStamp.TabIndex = 19;
      LbStationTimeStamp.Text = "...";
      // 
      // label14
      // 
      label14.Location = new Point(6, 22);
      label14.Margin = new Padding(3);
      label14.Name = "label14";
      label14.Size = new Size(150, 15);
      label14.TabIndex = 18;
      label14.Text = "Zeitpunkt:";
      label14.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationTodayPeakPower
      // 
      LbStationTodayPeakPower.AutoSize = true;
      LbStationTodayPeakPower.Location = new Point(162, 64);
      LbStationTodayPeakPower.Margin = new Padding(3);
      LbStationTodayPeakPower.Name = "LbStationTodayPeakPower";
      LbStationTodayPeakPower.Size = new Size(16, 15);
      LbStationTodayPeakPower.TabIndex = 17;
      LbStationTodayPeakPower.Text = "...";
      // 
      // LbStationTotalEnergy
      // 
      LbStationTotalEnergy.AutoSize = true;
      LbStationTotalEnergy.Location = new Point(572, 85);
      LbStationTotalEnergy.Margin = new Padding(3);
      LbStationTotalEnergy.Name = "LbStationTotalEnergy";
      LbStationTotalEnergy.Size = new Size(16, 15);
      LbStationTotalEnergy.TabIndex = 16;
      LbStationTotalEnergy.Text = "...";
      // 
      // label12
      // 
      label12.Location = new Point(416, 85);
      label12.Margin = new Padding(3);
      label12.Name = "label12";
      label12.Size = new Size(150, 15);
      label12.TabIndex = 15;
      label12.Text = "Gesamt:";
      label12.TextAlign = ContentAlignment.TopRight;
      // 
      // label10
      // 
      label10.Location = new Point(6, 64);
      label10.Margin = new Padding(3);
      label10.Name = "label10";
      label10.Size = new Size(150, 15);
      label10.TabIndex = 14;
      label10.Text = "Heutiger Spitzenwert:";
      label10.TextAlign = ContentAlignment.TopRight;
      // 
      // label9
      // 
      label9.Location = new Point(416, 64);
      label9.Margin = new Padding(3);
      label9.Name = "label9";
      label9.Size = new Size(150, 15);
      label9.TabIndex = 13;
      label9.Text = "Jahr gesamt:";
      label9.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationActivePower
      // 
      LbStationActivePower.AutoSize = true;
      LbStationActivePower.Location = new Point(162, 43);
      LbStationActivePower.Margin = new Padding(3);
      LbStationActivePower.Name = "LbStationActivePower";
      LbStationActivePower.Size = new Size(16, 15);
      LbStationActivePower.TabIndex = 12;
      LbStationActivePower.Text = "...";
      // 
      // LbStationCurrentYearEnergy
      // 
      LbStationCurrentYearEnergy.AutoSize = true;
      LbStationCurrentYearEnergy.Location = new Point(572, 64);
      LbStationCurrentYearEnergy.Margin = new Padding(3);
      LbStationCurrentYearEnergy.Name = "LbStationCurrentYearEnergy";
      LbStationCurrentYearEnergy.Size = new Size(16, 15);
      LbStationCurrentYearEnergy.TabIndex = 10;
      LbStationCurrentYearEnergy.Text = "...";
      // 
      // label13
      // 
      label13.Location = new Point(416, 43);
      label13.Margin = new Padding(3);
      label13.Name = "label13";
      label13.Size = new Size(150, 15);
      label13.TabIndex = 11;
      label13.Text = "Monat gesamt:";
      label13.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationCurrentMonthEnergy
      // 
      LbStationCurrentMonthEnergy.AutoSize = true;
      LbStationCurrentMonthEnergy.Location = new Point(572, 43);
      LbStationCurrentMonthEnergy.Margin = new Padding(3);
      LbStationCurrentMonthEnergy.Name = "LbStationCurrentMonthEnergy";
      LbStationCurrentMonthEnergy.Size = new Size(16, 15);
      LbStationCurrentMonthEnergy.TabIndex = 8;
      LbStationCurrentMonthEnergy.Text = "...";
      // 
      // label11
      // 
      label11.Location = new Point(416, 22);
      label11.Margin = new Padding(3);
      label11.Name = "label11";
      label11.Size = new Size(150, 15);
      label11.TabIndex = 9;
      label11.Text = "Heute gesamt:";
      label11.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationCurrentDayEnergy
      // 
      LbStationCurrentDayEnergy.AutoSize = true;
      LbStationCurrentDayEnergy.Location = new Point(572, 22);
      LbStationCurrentDayEnergy.Margin = new Padding(3);
      LbStationCurrentDayEnergy.Name = "LbStationCurrentDayEnergy";
      LbStationCurrentDayEnergy.Size = new Size(16, 15);
      LbStationCurrentDayEnergy.TabIndex = 7;
      LbStationCurrentDayEnergy.Text = "...";
      // 
      // label8
      // 
      label8.Location = new Point(6, 43);
      label8.Margin = new Padding(3);
      label8.Name = "label8";
      label8.Size = new Size(150, 15);
      label8.TabIndex = 7;
      label8.Text = "Aktuelle Leistung:";
      label8.TextAlign = ContentAlignment.TopRight;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(label5);
      groupBox1.Controls.Add(LbStationAddress);
      groupBox1.Controls.Add(LbStationId);
      groupBox1.Controls.Add(label7);
      groupBox1.Controls.Add(label6);
      groupBox1.Controls.Add(LbStationGuid);
      groupBox1.Location = new Point(6, 6);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(758, 70);
      groupBox1.TabIndex = 7;
      groupBox1.TabStop = false;
      groupBox1.Text = "Allgemeines";
      // 
      // label5
      // 
      label5.Location = new Point(6, 22);
      label5.Margin = new Padding(3);
      label5.Name = "label5";
      label5.Size = new Size(53, 15);
      label5.TabIndex = 1;
      label5.Text = "Id:";
      label5.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationAddress
      // 
      LbStationAddress.AutoSize = true;
      LbStationAddress.Location = new Point(65, 43);
      LbStationAddress.Margin = new Padding(3);
      LbStationAddress.Name = "LbStationAddress";
      LbStationAddress.Size = new Size(16, 15);
      LbStationAddress.TabIndex = 6;
      LbStationAddress.Text = "...";
      // 
      // LbStationId
      // 
      LbStationId.AutoSize = true;
      LbStationId.Location = new Point(65, 22);
      LbStationId.Margin = new Padding(3);
      LbStationId.Name = "LbStationId";
      LbStationId.Size = new Size(16, 15);
      LbStationId.TabIndex = 2;
      LbStationId.Text = "...";
      // 
      // label7
      // 
      label7.Location = new Point(6, 43);
      label7.Margin = new Padding(3);
      label7.Name = "label7";
      label7.Size = new Size(53, 15);
      label7.TabIndex = 5;
      label7.Text = "Adresse:";
      label7.TextAlign = ContentAlignment.TopRight;
      // 
      // label6
      // 
      label6.Location = new Point(125, 22);
      label6.Margin = new Padding(3);
      label6.Name = "label6";
      label6.Size = new Size(53, 15);
      label6.TabIndex = 3;
      label6.Text = "Guid:";
      label6.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationGuid
      // 
      LbStationGuid.AutoSize = true;
      LbStationGuid.Location = new Point(184, 22);
      LbStationGuid.Margin = new Padding(3);
      LbStationGuid.Name = "LbStationGuid";
      LbStationGuid.Size = new Size(16, 15);
      LbStationGuid.TabIndex = 4;
      LbStationGuid.Text = "...";
      // 
      // tabPage4
      // 
      tabPage4.Controls.Add(CbHistoryType);
      tabPage4.Controls.Add(label3);
      tabPage4.Location = new Point(4, 24);
      tabPage4.Name = "tabPage4";
      tabPage4.Padding = new Padding(3);
      tabPage4.Size = new Size(770, 335);
      tabPage4.TabIndex = 3;
      tabPage4.Text = "Historie";
      tabPage4.UseVisualStyleBackColor = true;
      // 
      // CbHistoryType
      // 
      CbHistoryType.DropDownStyle = ComboBoxStyle.DropDownList;
      CbHistoryType.FormattingEnabled = true;
      CbHistoryType.Items.AddRange(new object[] { "Tag", "Monat", "Jahr" });
      CbHistoryType.Location = new Point(59, 6);
      CbHistoryType.Name = "CbHistoryType";
      CbHistoryType.Size = new Size(121, 23);
      CbHistoryType.TabIndex = 1;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(6, 9);
      label3.Name = "label3";
      label3.Size = new Size(47, 15);
      label3.TabIndex = 0;
      label3.Text = "Ansicht";
      // 
      // BtnDisconnect
      // 
      BtnDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnDisconnect.Location = new Point(566, 6);
      BtnDisconnect.Name = "BtnDisconnect";
      BtnDisconnect.Size = new Size(100, 30);
      BtnDisconnect.TabIndex = 6;
      BtnDisconnect.Text = "Trennen";
      BtnDisconnect.UseVisualStyleBackColor = true;
      BtnDisconnect.Click += BtnDisconnect_Click;
      // 
      // BtnRefresh
      // 
      BtnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnRefresh.Location = new Point(672, 6);
      BtnRefresh.Name = "BtnRefresh";
      BtnRefresh.Size = new Size(100, 30);
      BtnRefresh.TabIndex = 8;
      BtnRefresh.Text = "Aktualisieren";
      BtnRefresh.UseVisualStyleBackColor = true;
      BtnRefresh.Click += BtnRefresh_Click;
      // 
      // CbStations
      // 
      CbStations.DropDownStyle = ComboBoxStyle.DropDownList;
      CbStations.FormattingEnabled = true;
      CbStations.Location = new Point(63, 11);
      CbStations.Name = "CbStations";
      CbStations.Size = new Size(334, 23);
      CbStations.TabIndex = 7;
      CbStations.SelectedIndexChanged += CbStations_SelectedIndexChanged;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(13, 14);
      label4.Name = "label4";
      label4.Size = new Size(44, 15);
      label4.TabIndex = 5;
      label4.Text = "Station";
      // 
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(784, 561);
      Controls.Add(PnBody);
      Controls.Add(PnHeader);
      Controls.Add(PnFooter);
      Name = "FormMain";
      StartPosition = FormStartPosition.CenterScreen;
      Tag = "TSunInverterMonitor - {0}";
      Text = "TSunInverterMonitor - Nicht verbunden";
      FormClosing += FormMain_FormClosing;
      PnFooter.ResumeLayout(false);
      PnHeader.ResumeLayout(false);
      PnHeader.PerformLayout();
      PnBody.ResumeLayout(false);
      PnBody.PerformLayout();
      tabControl1.ResumeLayout(false);
      tabPage2.ResumeLayout(false);
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      tabPage4.ResumeLayout(false);
      tabPage4.PerformLayout();
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
    private TabControl tabControl1;
    private TabPage tabPage2;
    private TabPage tabPage4;
    private Label LbStationGuid;
    private Label label6;
    private Label LbStationId;
    private Label label5;
    private GroupBox groupBox1;
    private Label LbStationAddress;
    private Label label7;
    private ComboBox CbHistoryType;
    private Label label3;
    private GroupBox groupBox2;
    private Label LbStationCurrentYearEnergy;
    private Label label13;
    private Label LbStationCurrentMonthEnergy;
    private Label label11;
    private Label LbStationCurrentDayEnergy;
    private Label label8;
    private Label LbStationActivePower;
    private Label label10;
    private Label label9;
    private Label LbStationTotalEnergy;
    private Label label12;
    private Label LbStationTodayPeakPower;
    private Label LbStationTimeStamp;
    private Label label14;
  }
}