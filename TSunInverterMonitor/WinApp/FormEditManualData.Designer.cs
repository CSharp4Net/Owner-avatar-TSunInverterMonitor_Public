namespace NZZ.TSIM.WinApp
{
  partial class FormEditManualData
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditManualData));
      panel1 = new Panel();
      BtnSave = new Button();
      BtnAbort = new Button();
      GridData = new DataGridView();
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.Controls.Add(BtnSave);
      panel1.Controls.Add(BtnAbort);
      panel1.Dock = DockStyle.Bottom;
      panel1.Location = new Point(0, 211);
      panel1.Name = "panel1";
      panel1.Size = new Size(384, 50);
      panel1.TabIndex = 3;
      // 
      // BtnSave
      // 
      BtnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      BtnSave.Location = new Point(297, 8);
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
      // GridData
      // 
      GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      GridData.Dock = DockStyle.Fill;
      GridData.Location = new Point(0, 0);
      GridData.Name = "GridData";
      GridData.RowTemplate.Height = 25;
      GridData.Size = new Size(384, 211);
      GridData.TabIndex = 4;
      // 
      // FormEditManualData
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(384, 261);
      Controls.Add(GridData);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      Icon = (Icon)resources.GetObject("$this.Icon");
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FormEditManualData";
      StartPosition = FormStartPosition.CenterParent;
      Text = "T-SUN Inverter Monitor - Manuelle Eingabe";
      panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button BtnSave;
    private Button BtnAbort;
    private DataGridView GridData;
  }
}