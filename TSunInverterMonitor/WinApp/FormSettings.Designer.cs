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
      groupBox1 = new GroupBox();
      label2 = new Label();
      TbServiceApiPattern = new TextBox();
      TbServiceRootUrl = new TextBox();
      label1 = new Label();
      groupBox2 = new GroupBox();
      BtnBrowse = new Button();
      label5 = new Label();
      CkAggregationLogEnabled = new CheckBox();
      TbAggregationLogFolderPath = new TextBox();
      panel1 = new Panel();
      BtnSave = new Button();
      BtnAbort = new Button();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // groupBox1
      // 
      groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      groupBox1.Controls.Add(label2);
      groupBox1.Controls.Add(TbServiceApiPattern);
      groupBox1.Controls.Add(TbServiceRootUrl);
      groupBox1.Controls.Add(label1);
      groupBox1.Location = new Point(12, 12);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(460, 82);
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
      TbServiceApiPattern.Size = new Size(100, 23);
      TbServiceApiPattern.TabIndex = 2;
      // 
      // TbServiceRootUrl
      // 
      TbServiceRootUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TbServiceRootUrl.Location = new Point(106, 22);
      TbServiceRootUrl.Name = "TbServiceRootUrl";
      TbServiceRootUrl.PlaceholderText = "Root-URL zur API, bspw.: https://www.talent-monitoring.com";
      TbServiceRootUrl.Size = new Size(348, 23);
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
      groupBox2.Controls.Add(BtnBrowse);
      groupBox2.Controls.Add(label5);
      groupBox2.Controls.Add(CkAggregationLogEnabled);
      groupBox2.Controls.Add(TbAggregationLogFolderPath);
      groupBox2.Location = new Point(12, 100);
      groupBox2.Name = "groupBox2";
      groupBox2.Size = new Size(460, 88);
      groupBox2.TabIndex = 1;
      groupBox2.TabStop = false;
      groupBox2.Text = "Datenprotokoll";
      // 
      // BtnBrowse
      // 
      BtnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnBrowse.Location = new Point(417, 49);
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
      // CkAggregationLogEnabled
      // 
      CkAggregationLogEnabled.AutoSize = true;
      CkAggregationLogEnabled.Location = new Point(106, 24);
      CkAggregationLogEnabled.Name = "CkAggregationLogEnabled";
      CkAggregationLogEnabled.Size = new Size(227, 19);
      CkAggregationLogEnabled.TabIndex = 1;
      CkAggregationLogEnabled.Text = "Aggregierte Daten lokal protokollieren";
      CkAggregationLogEnabled.UseVisualStyleBackColor = true;
      CkAggregationLogEnabled.CheckedChanged += CkAggregationLogEnabled_CheckedChanged;
      // 
      // TbAggregationLogFolderPath
      // 
      TbAggregationLogFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      TbAggregationLogFolderPath.Location = new Point(106, 49);
      TbAggregationLogFolderPath.Name = "TbAggregationLogFolderPath";
      TbAggregationLogFolderPath.PlaceholderText = "Verzeichnispfad zur Ablage ihrer T-SUN Leistungsdaten";
      TbAggregationLogFolderPath.Size = new Size(305, 23);
      TbAggregationLogFolderPath.TabIndex = 0;
      // 
      // panel1
      // 
      panel1.Controls.Add(BtnSave);
      panel1.Controls.Add(BtnAbort);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(0, 194);
      panel1.Name = "panel1";
      panel1.Size = new Size(484, 50);
      panel1.TabIndex = 2;
      // 
      // BtnSave
      // 
      BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnSave.Location = new Point(397, 8);
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
      // FormSettings
      // 
      AcceptButton = BtnSave;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(484, 244);
      Controls.Add(panel1);
      Controls.Add(groupBox2);
      Controls.Add(groupBox1);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormSettings";
      StartPosition = FormStartPosition.CenterParent;
      Text = "Einstellungen";
      Load += FormSettings_Load;
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      panel1.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private TextBox TbServiceRootUrl;
    private Label label1;
    private TextBox TbServiceApiPattern;
    private Label label4;
    private Label label3;
    private TextBox textBox2;
    private TextBox TbServ;
    private Label label2;
    private GroupBox groupBox2;
    private Label label5;
    private CheckBox CkAggregationLogEnabled;
    private TextBox TbAggregationLogFolderPath;
    private Panel panel1;
    private Button BtnSave;
    private Button BtnAbort;
    private Button BtnBrowse;
  }
}