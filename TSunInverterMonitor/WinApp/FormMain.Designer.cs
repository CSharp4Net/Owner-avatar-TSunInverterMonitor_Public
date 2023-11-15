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
      components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      PnFooter = new Panel();
      LbLog = new ListBox();
      PnHeader = new Panel();
      BtnOpenWorkFolder = new FontAwesome.Sharp.IconButton();
      BtnOpenSettings = new FontAwesome.Sharp.IconButton();
      TbServicePassword = new TextBox();
      label2 = new Label();
      TbServiceUserName = new TextBox();
      label1 = new Label();
      BtnConnect = new Button();
      PnBody = new Panel();
      ChHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
      panel2 = new Panel();
      BtnEditManualValue = new Button();
      BtnReloadHistory = new Button();
      label5 = new Label();
      BtnDayAfter = new Button();
      BtnDayBefore = new Button();
      DpHistoryDate = new DateTimePicker();
      label16 = new Label();
      LbHistoryTotal = new Label();
      CbHistoryType = new ComboBox();
      panel1 = new Panel();
      BtnOpenHistoryFolder = new Button();
      LbStationTotalEnergy = new Label();
      LbStationTimeStamp = new Label();
      LbStationAddress = new Label();
      LbStationCurrentEnergy = new Label();
      LbStationActivePower = new Label();
      label12 = new Label();
      BtnDisconnect = new Button();
      label4 = new Label();
      label11 = new Label();
      BtnRefresh = new Button();
      CbStations = new ComboBox();
      label8 = new Label();
      TmAutoSync = new System.Windows.Forms.Timer(components);
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
      PnHeader.Controls.Add(BtnOpenSettings);
      PnHeader.Controls.Add(TbServicePassword);
      PnHeader.Controls.Add(label2);
      PnHeader.Controls.Add(TbServiceUserName);
      PnHeader.Controls.Add(label1);
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
      BtnOpenWorkFolder.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
      BtnOpenWorkFolder.IconColor = Color.RoyalBlue;
      BtnOpenWorkFolder.IconFont = FontAwesome.Sharp.IconFont.Auto;
      BtnOpenWorkFolder.Location = new Point(1117, 11);
      BtnOpenWorkFolder.Name = "BtnOpenWorkFolder";
      BtnOpenWorkFolder.Size = new Size(54, 54);
      BtnOpenWorkFolder.TabIndex = 9;
      BtnOpenWorkFolder.Tag = "";
      BtnOpenWorkFolder.UseVisualStyleBackColor = true;
      BtnOpenWorkFolder.Click += BtnOpenWorkFolder_Click;
      // 
      // BtnOpenSettings
      // 
      BtnOpenSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnOpenSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
      BtnOpenSettings.IconColor = Color.RoyalBlue;
      BtnOpenSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
      BtnOpenSettings.Location = new Point(1057, 11);
      BtnOpenSettings.Name = "BtnOpenSettings";
      BtnOpenSettings.Size = new Size(54, 54);
      BtnOpenSettings.TabIndex = 8;
      BtnOpenSettings.Tag = "";
      BtnOpenSettings.UseVisualStyleBackColor = true;
      BtnOpenSettings.Click += BtnOpenSettings_Click;
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
      panel2.Controls.Add(BtnEditManualValue);
      panel2.Controls.Add(BtnReloadHistory);
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
      // BtnEditManualValue
      // 
      BtnEditManualValue.Location = new Point(867, 6);
      BtnEditManualValue.Name = "BtnEditManualValue";
      BtnEditManualValue.Size = new Size(150, 25);
      BtnEditManualValue.TabIndex = 25;
      BtnEditManualValue.Text = "Manuelle Eingabe";
      BtnEditManualValue.UseVisualStyleBackColor = true;
      BtnEditManualValue.Visible = false;
      BtnEditManualValue.Click += BtnEditManualValue_Click;
      // 
      // BtnReloadHistory
      // 
      BtnReloadHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnReloadHistory.Location = new Point(1022, 6);
      BtnReloadHistory.Name = "BtnReloadHistory";
      BtnReloadHistory.Size = new Size(150, 25);
      BtnReloadHistory.TabIndex = 24;
      BtnReloadHistory.Text = "Neu abrufen";
      BtnReloadHistory.UseVisualStyleBackColor = true;
      BtnReloadHistory.Click += BtnReloadHistory_Click;
      // 
      // label5
      // 
      label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
      label5.Location = new Point(13, 10);
      label5.Margin = new Padding(3);
      label5.Name = "label5";
      label5.Size = new Size(80, 17);
      label5.TabIndex = 20;
      label5.Text = "Anzeige:";
      label5.TextAlign = ContentAlignment.TopRight;
      // 
      // BtnDayAfter
      // 
      BtnDayAfter.Location = new Point(474, 6);
      BtnDayAfter.Name = "BtnDayAfter";
      BtnDayAfter.Size = new Size(25, 25);
      BtnDayAfter.TabIndex = 13;
      BtnDayAfter.Text = ">";
      BtnDayAfter.UseVisualStyleBackColor = true;
      BtnDayAfter.Click += BtnDayAfter_Click;
      // 
      // BtnDayBefore
      // 
      BtnDayBefore.Location = new Point(287, 6);
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
      DpHistoryDate.Location = new Point(318, 6);
      DpHistoryDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      DpHistoryDate.Name = "DpHistoryDate";
      DpHistoryDate.Size = new Size(150, 25);
      DpHistoryDate.TabIndex = 4;
      DpHistoryDate.ValueChanged += DpHistoryDate_ValueChanged;
      // 
      // label16
      // 
      label16.Location = new Point(505, 10);
      label16.Margin = new Padding(3);
      label16.Name = "label16";
      label16.Size = new Size(100, 17);
      label16.TabIndex = 11;
      label16.Text = "Gesamt:";
      label16.TextAlign = ContentAlignment.TopRight;
      // 
      // LbHistoryTotal
      // 
      LbHistoryTotal.AutoSize = true;
      LbHistoryTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      LbHistoryTotal.Location = new Point(611, 12);
      LbHistoryTotal.Margin = new Padding(3);
      LbHistoryTotal.Name = "LbHistoryTotal";
      LbHistoryTotal.Size = new Size(16, 15);
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
      panel1.Controls.Add(BtnOpenHistoryFolder);
      panel1.Controls.Add(LbStationTotalEnergy);
      panel1.Controls.Add(LbStationTimeStamp);
      panel1.Controls.Add(LbStationAddress);
      panel1.Controls.Add(LbStationCurrentEnergy);
      panel1.Controls.Add(LbStationActivePower);
      panel1.Controls.Add(label12);
      panel1.Controls.Add(BtnDisconnect);
      panel1.Controls.Add(label4);
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
      // BtnOpenHistoryFolder
      // 
      BtnOpenHistoryFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnOpenHistoryFolder.Location = new Point(1021, 69);
      BtnOpenHistoryFolder.Name = "BtnOpenHistoryFolder";
      BtnOpenHistoryFolder.Size = new Size(150, 25);
      BtnOpenHistoryFolder.TabIndex = 24;
      BtnOpenHistoryFolder.Text = "Protokollverzeichnis ...";
      BtnOpenHistoryFolder.UseVisualStyleBackColor = true;
      BtnOpenHistoryFolder.Click += BtnOpenHistoryFolder_Click;
      // 
      // LbStationTotalEnergy
      // 
      LbStationTotalEnergy.AutoSize = true;
      LbStationTotalEnergy.Location = new Point(473, 40);
      LbStationTotalEnergy.Margin = new Padding(3);
      LbStationTotalEnergy.Name = "LbStationTotalEnergy";
      LbStationTotalEnergy.Size = new Size(17, 17);
      LbStationTotalEnergy.TabIndex = 16;
      LbStationTotalEnergy.Text = "...";
      LbStationTotalEnergy.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationTimeStamp
      // 
      LbStationTimeStamp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      LbStationTimeStamp.Location = new Point(866, 12);
      LbStationTimeStamp.Margin = new Padding(3);
      LbStationTimeStamp.Name = "LbStationTimeStamp";
      LbStationTimeStamp.Size = new Size(150, 17);
      LbStationTimeStamp.TabIndex = 19;
      LbStationTimeStamp.Text = "...";
      LbStationTimeStamp.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationAddress
      // 
      LbStationAddress.AutoSize = true;
      LbStationAddress.Location = new Point(473, 12);
      LbStationAddress.Margin = new Padding(3);
      LbStationAddress.Name = "LbStationAddress";
      LbStationAddress.Size = new Size(17, 17);
      LbStationAddress.TabIndex = 6;
      LbStationAddress.Text = "...";
      // 
      // LbStationCurrentEnergy
      // 
      LbStationCurrentEnergy.AutoSize = true;
      LbStationCurrentEnergy.Location = new Point(167, 63);
      LbStationCurrentEnergy.Margin = new Padding(3);
      LbStationCurrentEnergy.Name = "LbStationCurrentEnergy";
      LbStationCurrentEnergy.Size = new Size(17, 17);
      LbStationCurrentEnergy.TabIndex = 7;
      LbStationCurrentEnergy.Text = "...";
      LbStationCurrentEnergy.TextAlign = ContentAlignment.TopRight;
      // 
      // LbStationActivePower
      // 
      LbStationActivePower.AutoSize = true;
      LbStationActivePower.Location = new Point(167, 40);
      LbStationActivePower.Margin = new Padding(3);
      LbStationActivePower.Name = "LbStationActivePower";
      LbStationActivePower.Size = new Size(17, 17);
      LbStationActivePower.TabIndex = 12;
      LbStationActivePower.Text = "...";
      // 
      // label12
      // 
      label12.Location = new Point(317, 40);
      label12.Margin = new Padding(3);
      label12.Name = "label12";
      label12.Size = new Size(150, 17);
      label12.TabIndex = 15;
      label12.Text = "Insgesamt:";
      label12.TextAlign = ContentAlignment.TopRight;
      // 
      // BtnDisconnect
      // 
      BtnDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnDisconnect.Location = new Point(1021, 38);
      BtnDisconnect.Name = "BtnDisconnect";
      BtnDisconnect.Size = new Size(150, 25);
      BtnDisconnect.TabIndex = 6;
      BtnDisconnect.Text = "Trennen";
      BtnDisconnect.UseVisualStyleBackColor = true;
      BtnDisconnect.Click += BtnDisconnect_Click;
      // 
      // label4
      // 
      label4.Location = new Point(81, 12);
      label4.Margin = new Padding(3);
      label4.Name = "label4";
      label4.Size = new Size(80, 17);
      label4.TabIndex = 5;
      label4.Text = "Station:";
      label4.TextAlign = ContentAlignment.TopRight;
      // 
      // label11
      // 
      label11.Location = new Point(11, 63);
      label11.Margin = new Padding(3);
      label11.Name = "label11";
      label11.Size = new Size(150, 17);
      label11.TabIndex = 9;
      label11.Text = "Heute/Monat/Jahr:";
      label11.TextAlign = ContentAlignment.TopRight;
      // 
      // BtnRefresh
      // 
      BtnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnRefresh.Location = new Point(1021, 8);
      BtnRefresh.Name = "BtnRefresh";
      BtnRefresh.Size = new Size(150, 25);
      BtnRefresh.TabIndex = 8;
      BtnRefresh.Text = "Synchronisieren";
      BtnRefresh.UseVisualStyleBackColor = true;
      BtnRefresh.Click += BtnRefresh_Click;
      // 
      // CbStations
      // 
      CbStations.DropDownStyle = ComboBoxStyle.DropDownList;
      CbStations.FormattingEnabled = true;
      CbStations.Location = new Point(167, 9);
      CbStations.Name = "CbStations";
      CbStations.Size = new Size(300, 25);
      CbStations.TabIndex = 7;
      CbStations.SelectedIndexChanged += CbStations_SelectedIndexChanged;
      // 
      // label8
      // 
      label8.Location = new Point(11, 40);
      label8.Margin = new Padding(3);
      label8.Name = "label8";
      label8.Size = new Size(150, 17);
      label8.TabIndex = 7;
      label8.Text = "Aktuelle Leistung:";
      label8.TextAlign = ContentAlignment.TopRight;
      // 
      // TmAutoSync
      // 
      TmAutoSync.Interval = 300000;
      TmAutoSync.Tick += TmAutoSync_Tick;
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
      Tag = "T-SUN Inverter Monitor - {0}";
      Text = "T-SUN Inverter Monitor - Nicht verbunden";
      FormClosing += FormMain_FormClosing;
      PnFooter.ResumeLayout(false);
      PnHeader.ResumeLayout(false);
      PnHeader.PerformLayout();
      PnBody.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)ChHistory).EndInit();
      panel2.ResumeLayout(false);
      panel2.PerformLayout();
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion
    private Panel PnFooter;
    private Panel PnHeader;
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
    private Label LbStationTimeStamp;
    private Label LbStationTotalEnergy;
    private Label label12;
    private Label LbStationActivePower;
    private Label label11;
    private Label LbStationCurrentEnergy;
    private Label label8;
    private Label LbStationAddress;
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
    private Label label15;
    private Button BtnReloadHistory;
    private Button BtnOpenHistoryFolder;
    private System.Windows.Forms.Timer TmAutoSync;
    private FontAwesome.Sharp.IconButton BtnOpenSettings;
    private FontAwesome.Sharp.IconButton BtnOpenWorkFolder;
    private Button BtnEditManualValue;
  }
}