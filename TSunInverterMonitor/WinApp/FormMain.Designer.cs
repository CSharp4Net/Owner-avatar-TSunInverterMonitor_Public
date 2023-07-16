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
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45117.221678240741D, 0D);
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45117.232094907406D, "8,5");
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45117.242511574077D, "14,39");
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45117.252928240741D, "21,6");
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45117.263344907406D, "26,39");
      System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(45117.273761574077D, "38,59");
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      PnFooter = new Panel();
      LbLog = new ListBox();
      PnHeader = new Panel();
      BtnDebug = new Button();
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
      ChHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
      panel2 = new Panel();
      BtnDayAfter = new Button();
      BtnDayBefore = new Button();
      DpHistoryDate = new DateTimePicker();
      label16 = new Label();
      label3 = new Label();
      LbHistoryTotal = new Label();
      CbHistoryType = new ComboBox();
      panel1 = new Panel();
      BtnDisconnect = new Button();
      label4 = new Label();
      BtnRefresh = new Button();
      CbStations = new ComboBox();
      PnFooter.SuspendLayout();
      PnHeader.SuspendLayout();
      PnBody.SuspendLayout();
      tabControl1.SuspendLayout();
      tabPage2.SuspendLayout();
      groupBox2.SuspendLayout();
      groupBox1.SuspendLayout();
      tabPage4.SuspendLayout();
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
      PnFooter.Location = new Point(0, 661);
      PnFooter.Name = "PnFooter";
      PnFooter.Size = new Size(1184, 100);
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
      LbLog.Size = new Size(1182, 98);
      LbLog.TabIndex = 0;
      // 
      // PnHeader
      // 
      PnHeader.BorderStyle = BorderStyle.FixedSingle;
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
      PnHeader.Size = new Size(1184, 50);
      PnHeader.TabIndex = 2;
      // 
      // BtnDebug
      // 
      BtnDebug.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnDebug.Location = new Point(859, 11);
      BtnDebug.Name = "BtnDebug";
      BtnDebug.Size = new Size(100, 30);
      BtnDebug.TabIndex = 6;
      BtnDebug.Text = "DEBUG";
      BtnDebug.UseVisualStyleBackColor = true;
      BtnDebug.Click += BtnDebug_Click;
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
      BtnOpenSettings.Location = new Point(1071, 11);
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
      BtnConnect.Location = new Point(965, 11);
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
      PnBody.Controls.Add(panel1);
      PnBody.Dock = DockStyle.Fill;
      PnBody.Location = new Point(0, 50);
      PnBody.Name = "PnBody";
      PnBody.Size = new Size(1184, 611);
      PnBody.TabIndex = 3;
      PnBody.Visible = false;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Controls.Add(tabPage4);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 40);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(1184, 571);
      tabControl1.TabIndex = 10;
      // 
      // tabPage2
      // 
      tabPage2.Controls.Add(groupBox2);
      tabPage2.Controls.Add(groupBox1);
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(1176, 543);
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
      groupBox2.Size = new Size(758, 171);
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
      LbStationTotalEnergy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      LbStationTotalEnergy.Location = new Point(162, 148);
      LbStationTotalEnergy.Margin = new Padding(3);
      LbStationTotalEnergy.Name = "LbStationTotalEnergy";
      LbStationTotalEnergy.Size = new Size(16, 15);
      LbStationTotalEnergy.TabIndex = 16;
      LbStationTotalEnergy.Text = "...";
      // 
      // label12
      // 
      label12.Location = new Point(6, 148);
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
      label9.Location = new Point(6, 127);
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
      LbStationActivePower.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
      LbStationCurrentYearEnergy.Location = new Point(162, 127);
      LbStationCurrentYearEnergy.Margin = new Padding(3);
      LbStationCurrentYearEnergy.Name = "LbStationCurrentYearEnergy";
      LbStationCurrentYearEnergy.Size = new Size(16, 15);
      LbStationCurrentYearEnergy.TabIndex = 10;
      LbStationCurrentYearEnergy.Text = "...";
      // 
      // label13
      // 
      label13.Location = new Point(6, 106);
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
      LbStationCurrentMonthEnergy.Location = new Point(162, 106);
      LbStationCurrentMonthEnergy.Margin = new Padding(3);
      LbStationCurrentMonthEnergy.Name = "LbStationCurrentMonthEnergy";
      LbStationCurrentMonthEnergy.Size = new Size(16, 15);
      LbStationCurrentMonthEnergy.TabIndex = 8;
      LbStationCurrentMonthEnergy.Text = "...";
      // 
      // label11
      // 
      label11.Location = new Point(6, 85);
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
      LbStationCurrentDayEnergy.Location = new Point(162, 85);
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
      tabPage4.Controls.Add(ChHistory);
      tabPage4.Controls.Add(panel2);
      tabPage4.Location = new Point(4, 24);
      tabPage4.Name = "tabPage4";
      tabPage4.Padding = new Padding(3);
      tabPage4.Size = new Size(1176, 543);
      tabPage4.TabIndex = 3;
      tabPage4.Text = "Historie";
      tabPage4.UseVisualStyleBackColor = true;
      // 
      // ChHistory
      // 
      chartArea1.AxisY.LineColor = Color.Empty;
      chartArea1.AxisY.Maximum = 600D;
      chartArea1.Name = "Default";
      ChHistory.ChartAreas.Add(chartArea1);
      ChHistory.Dock = DockStyle.Fill;
      ChHistory.Location = new Point(3, 33);
      ChHistory.Name = "ChHistory";
      series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
      series1.BorderColor = Color.RoyalBlue;
      series1.BorderWidth = 2;
      series1.ChartArea = "Default";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
      series1.IsValueShownAsLabel = true;
      series1.IsXValueIndexed = true;
      series1.LabelForeColor = Color.RoyalBlue;
      series1.MarkerColor = Color.Navy;
      series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
      series1.Name = "Default";
      series1.Points.Add(dataPoint1);
      series1.Points.Add(dataPoint2);
      series1.Points.Add(dataPoint3);
      series1.Points.Add(dataPoint4);
      series1.Points.Add(dataPoint5);
      series1.Points.Add(dataPoint6);
      series1.ShadowColor = Color.Empty;
      series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
      series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
      ChHistory.Series.Add(series1);
      ChHistory.Size = new Size(1170, 507);
      ChHistory.TabIndex = 13;
      // 
      // panel2
      // 
      panel2.Controls.Add(BtnDayAfter);
      panel2.Controls.Add(BtnDayBefore);
      panel2.Controls.Add(DpHistoryDate);
      panel2.Controls.Add(label16);
      panel2.Controls.Add(label3);
      panel2.Controls.Add(LbHistoryTotal);
      panel2.Controls.Add(CbHistoryType);
      panel2.Dock = DockStyle.Top;
      panel2.Location = new Point(3, 3);
      panel2.Name = "panel2";
      panel2.Size = new Size(1170, 30);
      panel2.TabIndex = 12;
      // 
      // BtnDayAfter
      // 
      BtnDayAfter.Location = new Point(164, 3);
      BtnDayAfter.Name = "BtnDayAfter";
      BtnDayAfter.Size = new Size(25, 23);
      BtnDayAfter.TabIndex = 13;
      BtnDayAfter.Text = ">";
      BtnDayAfter.UseVisualStyleBackColor = true;
      BtnDayAfter.Click += BtnDayAfter_Click;
      // 
      // BtnDayBefore
      // 
      BtnDayBefore.Location = new Point(33, 3);
      BtnDayBefore.Name = "BtnDayBefore";
      BtnDayBefore.Size = new Size(25, 23);
      BtnDayBefore.TabIndex = 12;
      BtnDayBefore.Text = "<";
      BtnDayBefore.UseVisualStyleBackColor = true;
      BtnDayBefore.Click += BtnDayBefore_Click;
      // 
      // DpHistoryDate
      // 
      DpHistoryDate.Format = DateTimePickerFormat.Short;
      DpHistoryDate.Location = new Point(64, 3);
      DpHistoryDate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
      DpHistoryDate.Name = "DpHistoryDate";
      DpHistoryDate.Size = new Size(94, 23);
      DpHistoryDate.TabIndex = 4;
      DpHistoryDate.ValueChanged += HistoryControl_ValueChanged;
      // 
      // label16
      // 
      label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      label16.Location = new Point(959, 6);
      label16.Margin = new Padding(3);
      label16.Name = "label16";
      label16.Size = new Size(100, 15);
      label16.TabIndex = 11;
      label16.Text = "Gesamt:";
      label16.TextAlign = ContentAlignment.TopRight;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(246, 6);
      label3.Name = "label3";
      label3.Size = new Size(47, 15);
      label3.TabIndex = 0;
      label3.Text = "Ansicht";
      // 
      // LbHistoryTotal
      // 
      LbHistoryTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      LbHistoryTotal.AutoSize = true;
      LbHistoryTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
      LbHistoryTotal.Location = new Point(1065, 6);
      LbHistoryTotal.Margin = new Padding(3);
      LbHistoryTotal.Name = "LbHistoryTotal";
      LbHistoryTotal.Size = new Size(16, 15);
      LbHistoryTotal.TabIndex = 10;
      LbHistoryTotal.Text = "...";
      // 
      // CbHistoryType
      // 
      CbHistoryType.DropDownStyle = ComboBoxStyle.DropDownList;
      CbHistoryType.FormattingEnabled = true;
      CbHistoryType.Location = new Point(299, 3);
      CbHistoryType.Name = "CbHistoryType";
      CbHistoryType.Size = new Size(121, 23);
      CbHistoryType.TabIndex = 1;
      CbHistoryType.SelectedIndexChanged += HistoryControl_ValueChanged;
      // 
      // panel1
      // 
      panel1.Controls.Add(BtnDisconnect);
      panel1.Controls.Add(label4);
      panel1.Controls.Add(BtnRefresh);
      panel1.Controls.Add(CbStations);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1184, 40);
      panel1.TabIndex = 9;
      // 
      // BtnDisconnect
      // 
      BtnDisconnect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnDisconnect.Location = new Point(966, 6);
      BtnDisconnect.Name = "BtnDisconnect";
      BtnDisconnect.Size = new Size(100, 30);
      BtnDisconnect.TabIndex = 6;
      BtnDisconnect.Text = "Trennen";
      BtnDisconnect.UseVisualStyleBackColor = true;
      BtnDisconnect.Click += BtnDisconnect_Click;
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
      // BtnRefresh
      // 
      BtnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnRefresh.Location = new Point(1072, 6);
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
      // FormMain
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1184, 761);
      Controls.Add(PnBody);
      Controls.Add(PnHeader);
      Controls.Add(PnFooter);
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
      tabControl1.ResumeLayout(false);
      tabPage2.ResumeLayout(false);
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      tabPage4.ResumeLayout(false);
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
    private TabControl tabControl1;
    private TabPage tabPage2;
    private GroupBox groupBox2;
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
    private GroupBox groupBox1;
    private Label label5;
    private Label LbStationAddress;
    private Label LbStationId;
    private Label label7;
    private Label label6;
    private Label LbStationGuid;
    private TabPage tabPage4;
    private System.Windows.Forms.DataVisualization.Charting.Chart ChHistory;
    private Panel panel2;
    private DateTimePicker DpHistoryDate;
    private Label label16;
    private Label label3;
    private Label LbHistoryTotal;
    private ComboBox CbHistoryType;
    private Panel panel1;
    private Button BtnDayAfter;
    private Button BtnDayBefore;
  }
}