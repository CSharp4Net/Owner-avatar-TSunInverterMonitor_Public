namespace NZZ.TSIM.WinApp
{
  partial class FormSettings
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
      groupBox1 = new GroupBox();
      label2 = new Label();
      TbServiceApiPattern = new TextBox();
      TbServiceRootUrl = new TextBox();
      label1 = new Label();
      groupBox2 = new GroupBox();
      BtnBrowse = new Button();
      label5 = new Label();
      CkHistoryBackupEnabled = new CheckBox();
      TbHistoryBackupFolderPath = new TextBox();
      panel1 = new Panel();
      BtnSave = new Button();
      BtnAbort = new Button();
      CkAutoLogin = new CheckBox();
      groupBox3 = new GroupBox();
      CkAutoSyncService = new CheckBox();
      CkAutoMaximize = new CheckBox();
      tabControl1 = new TabControl();
      tabPage1 = new TabPage();
      tabPage2 = new TabPage();
      groupBox4 = new GroupBox();
      DpDayChartVisibleAreaEnd = new DateTimePicker();
      label4 = new Label();
      label3 = new Label();
      DpDayChartVisibleAreaBegin = new DateTimePicker();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      panel1.SuspendLayout();
      groupBox3.SuspendLayout();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      tabPage2.SuspendLayout();
      groupBox4.SuspendLayout();
      SuspendLayout();
      // 
      // groupBox1
      // 
      groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox1.Controls.Add(label2);
      groupBox1.Controls.Add(TbServiceApiPattern);
      groupBox1.Controls.Add(TbServiceRootUrl);
      groupBox1.Controls.Add(label1);
      groupBox1.Location = new Point(6, 6);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(564, 82);
      groupBox1.TabIndex = 0;
      groupBox1.TabStop = false;
      groupBox1.Text = "Dienstanbindung";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(6, 54);
      label2.Name = "label2";
      label2.Size = new Size(68, 15);
      label2.TabIndex = 3;
      label2.Text = "API-Pattern";
      // 
      // TbServiceApiPattern
      // 
      TbServiceApiPattern.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TbServiceApiPattern.Location = new Point(106, 51);
      TbServiceApiPattern.Name = "TbServiceApiPattern";
      TbServiceApiPattern.PlaceholderText = "prod-api";
      TbServiceApiPattern.Size = new Size(204, 23);
      TbServiceApiPattern.TabIndex = 2;
      // 
      // TbServiceRootUrl
      // 
      TbServiceRootUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TbServiceRootUrl.Location = new Point(106, 22);
      TbServiceRootUrl.Name = "TbServiceRootUrl";
      TbServiceRootUrl.PlaceholderText = "Root-URL zur API, bspw.: https://www.talent-monitoring.com";
      TbServiceRootUrl.Size = new Size(452, 23);
      TbServiceRootUrl.TabIndex = 1;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(6, 25);
      label1.Name = "label1";
      label1.Size = new Size(58, 15);
      label1.TabIndex = 0;
      label1.Text = "Root-URL";
      // 
      // groupBox2
      // 
      groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox2.Controls.Add(BtnBrowse);
      groupBox2.Controls.Add(label5);
      groupBox2.Controls.Add(CkHistoryBackupEnabled);
      groupBox2.Controls.Add(TbHistoryBackupFolderPath);
      groupBox2.Location = new Point(6, 94);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(564, 88);
      groupBox2.TabIndex = 1;
      groupBox2.TabStop = false;
      groupBox2.Text = "Datenprotokoll";
      // 
      // BtnBrowse
      // 
      BtnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnBrowse.Location = new Point(521, 49);
      BtnBrowse.Name = "BtnBrowse";
      BtnBrowse.Size = new Size(37, 23);
      BtnBrowse.TabIndex = 9;
      BtnBrowse.Text = "...";
      BtnBrowse.UseVisualStyleBackColor = true;
      BtnBrowse.Click += BtnBrowse_Click;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(6, 52);
      label5.Name = "label5";
      label5.Size = new Size(65, 15);
      label5.TabIndex = 8;
      label5.Text = "Verzeichnis";
      // 
      // CkHistoryBackupEnabled
      // 
      CkHistoryBackupEnabled.AutoSize = true;
      CkHistoryBackupEnabled.Location = new Point(106, 24);
      CkHistoryBackupEnabled.Name = "CkHistoryBackupEnabled";
      CkHistoryBackupEnabled.Size = new Size(227, 19);
      CkHistoryBackupEnabled.TabIndex = 1;
      CkHistoryBackupEnabled.Text = "Aggregierte Daten lokal protokollieren";
      CkHistoryBackupEnabled.UseVisualStyleBackColor = true;
      CkHistoryBackupEnabled.CheckedChanged += CkAggregationLogEnabled_CheckedChanged;
      // 
      // TbHistoryBackupFolderPath
      // 
      TbHistoryBackupFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TbHistoryBackupFolderPath.Location = new Point(106, 49);
      TbHistoryBackupFolderPath.Name = "TbHistoryBackupFolderPath";
      TbHistoryBackupFolderPath.PlaceholderText = "Verzeichnispfad zur Ablage ihrer T-SUN Leistungsdaten";
      TbHistoryBackupFolderPath.Size = new Size(409, 23);
      TbHistoryBackupFolderPath.TabIndex = 0;
      // 
      // panel1
      // 
      panel1.Controls.Add(BtnSave);
      panel1.Controls.Add(BtnAbort);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(0, 385);
      panel1.Name = "panel1";
      panel1.Size = new Size(584, 50);
      panel1.TabIndex = 2;
      // 
      // BtnSave
      // 
      BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnSave.Location = new Point(497, 8);
      BtnSave.Name = "BtnSave";
      BtnSave.Size = new Size(75, 30);
      BtnSave.TabIndex = 1;
      BtnSave.Text = "Speichern";
      BtnSave.UseVisualStyleBackColor = true;
      BtnSave.Click += BtnSave_Click;
      // 
      // BtnAbort
      // 
      BtnAbort.Location = new Point(12, 8);
      BtnAbort.Name = "BtnAbort";
      BtnAbort.Size = new Size(75, 30);
      BtnAbort.TabIndex = 0;
      BtnAbort.Text = "Abbrechen";
      BtnAbort.UseVisualStyleBackColor = true;
      BtnAbort.Click += BtnAbort_Click;
      // 
      // CkAutoLogin
      // 
      CkAutoLogin.AutoSize = true;
      CkAutoLogin.Location = new Point(6, 22);
      CkAutoLogin.Name = "CkAutoLogin";
      CkAutoLogin.Size = new Size(275, 19);
      CkAutoLogin.TabIndex = 2;
      CkAutoLogin.Text = "Automatisches Anmelden nach Programmstart";
      CkAutoLogin.UseVisualStyleBackColor = true;
      // 
      // groupBox3
      // 
      groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox3.Controls.Add(CkAutoSyncService);
      groupBox3.Controls.Add(CkAutoMaximize);
      groupBox3.Controls.Add(CkAutoLogin);
      groupBox3.Location = new Point(6, 188);
      groupBox3.Name = "groupBox3";
      groupBox3.Size = new Size(560, 100);
      groupBox3.TabIndex = 3;
      groupBox3.TabStop = false;
      groupBox3.Text = "Automatisierung";
      // 
      // CkAutoSyncService
      // 
      CkAutoSyncService.AutoSize = true;
      CkAutoSyncService.Location = new Point(6, 72);
      CkAutoSyncService.Name = "CkAutoSyncService";
      CkAutoSyncService.Size = new Size(372, 19);
      CkAutoSyncService.TabIndex = 4;
      CkAutoSyncService.Text = "Automatisches Synchroniseren aller 5 Minuten, wenn angemeldet";
      CkAutoSyncService.UseVisualStyleBackColor = true;
      // 
      // CkAutoMaximize
      // 
      CkAutoMaximize.AutoSize = true;
      CkAutoMaximize.Location = new Point(6, 47);
      CkAutoMaximize.Name = "CkAutoMaximize";
      CkAutoMaximize.Size = new Size(371, 19);
      CkAutoMaximize.TabIndex = 3;
      CkAutoMaximize.Text = "Automatisches Maximieren der Anwendung nach Programmstart";
      CkAutoMaximize.UseVisualStyleBackColor = true;
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 0);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(584, 385);
      tabControl1.TabIndex = 4;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(groupBox1);
      tabPage1.Controls.Add(groupBox3);
      tabPage1.Controls.Add(groupBox2);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(576, 357);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "Allgemeines";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      tabPage2.Controls.Add(groupBox4);
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(576, 357);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "Charts";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox4
      // 
      groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox4.Controls.Add(DpDayChartVisibleAreaBegin);
      groupBox4.Controls.Add(DpDayChartVisibleAreaEnd);
      groupBox4.Controls.Add(label4);
      groupBox4.Controls.Add(label3);
      groupBox4.Location = new Point(8, 6);
      groupBox4.Name = "groupBox4";
      groupBox4.Size = new Size(560, 100);
      groupBox4.TabIndex = 0;
      groupBox4.TabStop = false;
      groupBox4.Text = "Tages-Diagramm";
      // 
      // DpDayChartVisibleAreaEnd
      // 
      DpDayChartVisibleAreaEnd.CustomFormat = "HH:mm";
      DpDayChartVisibleAreaEnd.Format = DateTimePickerFormat.Custom;
      DpDayChartVisibleAreaEnd.Location = new Point(214, 22);
      DpDayChartVisibleAreaEnd.Name = "DpDayChartVisibleAreaEnd";
      DpDayChartVisibleAreaEnd.ShowUpDown = true;
      DpDayChartVisibleAreaEnd.Size = new Size(50, 23);
      DpDayChartVisibleAreaEnd.TabIndex = 4;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(186, 25);
      label4.Name = "label4";
      label4.Size = new Size(22, 15);
      label4.TabIndex = 3;
      label4.Text = "bis";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(6, 25);
      label3.Name = "label3";
      label3.Size = new Size(111, 15);
      label3.TabIndex = 0;
      label3.Text = "Sichtbarer Zeitraum";
      // 
      // DpDayChartVisibleAreaBegin
      // 
      DpDayChartVisibleAreaBegin.CustomFormat = "HH:mm";
      DpDayChartVisibleAreaBegin.Format = DateTimePickerFormat.Custom;
      DpDayChartVisibleAreaBegin.Location = new Point(130, 22);
      DpDayChartVisibleAreaBegin.Name = "DpDayChartVisibleAreaBegin";
      DpDayChartVisibleAreaBegin.ShowUpDown = true;
      DpDayChartVisibleAreaBegin.Size = new Size(50, 23);
      DpDayChartVisibleAreaBegin.TabIndex = 5;
      // 
      // FormSettings
      // 
      AcceptButton = BtnSave;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(584, 435);
      Controls.Add(tabControl1);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      Icon = (Icon)resources.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormSettings";
      StartPosition = FormStartPosition.CenterParent;
      Text = "T-SUN Inverter Monitor - Einstellungen";
      Load += FormSettings_Load;
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      panel1.ResumeLayout(false);
      groupBox3.ResumeLayout(false);
      groupBox3.PerformLayout();
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      tabPage2.ResumeLayout(false);
      groupBox4.ResumeLayout(false);
      groupBox4.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private TextBox TbServiceRootUrl;
    private Label label1;
    private TextBox TbServiceApiPattern;
    private Label label4;
    private TextBox textBox2;
    private TextBox TbServ;
    private Label label2;
    private GroupBox groupBox2;
    private Label label5;
    private CheckBox CkHistoryBackupEnabled;
    private TextBox TbHistoryBackupFolderPath;
    private Panel panel1;
    private Button BtnSave;
    private Button BtnAbort;
    private Button BtnBrowse;
    private CheckBox CkAutoLogin;
    private GroupBox groupBox3;
    private CheckBox CkAutoMaximize;
    private CheckBox CkAutoSyncService;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private GroupBox groupBox4;
    private Label label3;
    private DateTimePicker DpDayChartVisibleAreaEnd;
    private DateTimePicker DpDayChartVisibleAreaBegin;
  }
}