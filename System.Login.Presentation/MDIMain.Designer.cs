namespace System.Login.Presentation
{
    partial class MDIMain
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
            statusStrip = new StatusStrip();
            tspbProgress = new ToolStripProgressBar();
            tsslStatus = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslStatus, tspbProgress });
            statusStrip.Location = new Point(0, 316);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(700, 22);
            statusStrip.TabIndex = 1;
            // 
            // tspbProgress
            // 
            tspbProgress.Name = "tspbProgress";
            tspbProgress.Size = new Size(100, 16);
            // 
            // tsslStatus
            // 
            tsslStatus.Name = "tsslStatus";
            tsslStatus.Size = new Size(42, 17);
            tsslStatus.Text = "Estado";
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // MDIMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MDIMain";
            Text = "MDIMain";
            WindowState = FormWindowState.Maximized;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripProgressBar tspbProgress;
        private ToolStripStatusLabel tsslStatus;
        private MenuStrip menuStrip1;
    }
}