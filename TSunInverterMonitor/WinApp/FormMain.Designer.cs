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
            progressBar1 = new ProgressBar();
            panel1 = new Panel();
            panel2 = new Panel();
            BtnOpenSettings = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 8);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(760, 30);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(progressBar1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 511);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 50);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnOpenSettings);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 50);
            panel2.TabIndex = 2;
            // 
            // BtnOpenSettings
            // 
            BtnOpenSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnOpenSettings.Location = new Point(672, 12);
            BtnOpenSettings.Name = "BtnOpenSettings";
            BtnOpenSettings.Size = new Size(100, 30);
            BtnOpenSettings.TabIndex = 0;
            BtnOpenSettings.Text = "Einstellungen";
            BtnOpenSettings.UseVisualStyleBackColor = true;
            BtnOpenSettings.Click += BtnOpenSettings_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TSunInverterMonitor - WinApp";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Panel panel1;
        private Panel panel2;
        private Button BtnOpenSettings;
    }
}