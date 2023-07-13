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
            label1 = new Label();
            TbServiceRootUrl = new TextBox();
            ServiceApiPattern = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            TbAggregationLogFolderPath = new TextBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            panel1 = new Panel();
            BtnAbort = new Button();
            BtnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ServiceApiPattern);
            groupBox1.Controls.Add(TbServiceRootUrl);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dienstanbindung";
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
            // TbServiceRootUrl
            // 
            TbServiceRootUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbServiceRootUrl.Location = new Point(106, 22);
            TbServiceRootUrl.Name = "TbServiceRootUrl";
            TbServiceRootUrl.Size = new Size(348, 23);
            TbServiceRootUrl.TabIndex = 1;
            // 
            // ServiceApiPattern
            // 
            ServiceApiPattern.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ServiceApiPattern.Location = new Point(106, 51);
            ServiceApiPattern.Name = "ServiceApiPattern";
            ServiceApiPattern.Size = new Size(100, 23);
            ServiceApiPattern.TabIndex = 2;
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
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(106, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(106, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 112);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Kennwort";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(TbAggregationLogFolderPath);
            groupBox2.Location = new Point(12, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 88);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datenprotokoll";
            // 
            // TbAggregationLogFolderPath
            // 
            TbAggregationLogFolderPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TbAggregationLogFolderPath.Location = new Point(106, 49);
            TbAggregationLogFolderPath.Name = "TbAggregationLogFolderPath";
            TbAggregationLogFolderPath.Size = new Size(348, 23);
            TbAggregationLogFolderPath.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(106, 24);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(227, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Aggregierte Daten lokal protokollieren";
            checkBox1.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            panel1.Controls.Add(BtnSave);
            panel1.Controls.Add(BtnAbort);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 50);
            panel1.TabIndex = 2;
            // 
            // BtnAbort
            // 
            BtnAbort.Location = new Point(12, 8);
            BtnAbort.Name = "BtnAbort";
            BtnAbort.Size = new Size(75, 30);
            BtnAbort.TabIndex = 0;
            BtnAbort.Text = "Abbrechen";
            BtnAbort.UseVisualStyleBackColor = true;
            BtnAbort.Click += BtnAbort_Click_1;
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
            BtnSave.Click += BtnSave_Click_1;
            // 
            // FormSettings
            // 
            AcceptButton = BtnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 300);
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
        private TextBox ServiceApiPattern;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label5;
        private CheckBox checkBox1;
        private TextBox TbAggregationLogFolderPath;
        private Panel panel1;
        private Button BtnSave;
        private Button BtnAbort;
    }
}