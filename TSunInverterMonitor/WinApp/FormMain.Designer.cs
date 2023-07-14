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
      BtnDisconnect = new Button();
      BtnRefresh = new Button();
      CbStations = new ComboBox();
      label4 = new Label();
      PnFooter.SuspendLayout();
      PnHeader.SuspendLayout();
      PnBody.SuspendLayout();
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
      CbStations.Size = new Size(150, 23);
      CbStations.TabIndex = 7;
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
  }
}