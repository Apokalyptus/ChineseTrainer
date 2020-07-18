namespace ChineseTrainer
{
    partial class ChineseTrainer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChineseTrainer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbChinese = new System.Windows.Forms.TextBox();
            this.tbPinyin = new System.Windows.Forms.TextBox();
            this.tbGerman = new System.Windows.Forms.TextBox();
            this.myMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mStartStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.myMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbChinese
            // 
            this.tbChinese.BackColor = System.Drawing.Color.White;
            this.tbChinese.Enabled = false;
            this.tbChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChinese.Location = new System.Drawing.Point(13, 12);
            this.tbChinese.Multiline = true;
            this.tbChinese.Name = "tbChinese";
            this.tbChinese.ReadOnly = true;
            this.tbChinese.Size = new System.Drawing.Size(267, 95);
            this.tbChinese.TabIndex = 3;
            this.tbChinese.Text = "爸爸爸";
            this.tbChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChinese.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPinyin
            // 
            this.tbPinyin.BackColor = System.Drawing.Color.White;
            this.tbPinyin.Enabled = false;
            this.tbPinyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinyin.Location = new System.Drawing.Point(13, 113);
            this.tbPinyin.Multiline = true;
            this.tbPinyin.Name = "tbPinyin";
            this.tbPinyin.ReadOnly = true;
            this.tbPinyin.Size = new System.Drawing.Size(267, 57);
            this.tbPinyin.TabIndex = 4;
            this.tbPinyin.Text = "zhōngguó";
            this.tbPinyin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGerman
            // 
            this.tbGerman.BackColor = System.Drawing.Color.White;
            this.tbGerman.Enabled = false;
            this.tbGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGerman.Location = new System.Drawing.Point(12, 176);
            this.tbGerman.Multiline = true;
            this.tbGerman.Name = "tbGerman";
            this.tbGerman.ReadOnly = true;
            this.tbGerman.Size = new System.Drawing.Size(267, 57);
            this.tbGerman.TabIndex = 5;
            this.tbGerman.Text = "German";
            this.tbGerman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGerman.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.mConfig,
            this.mStartStop,
            this.mExit});
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(121, 92);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // mConfig
            // 
            this.mConfig.Name = "mConfig";
            this.mConfig.Size = new System.Drawing.Size(120, 22);
            this.mConfig.Text = "Config";
            // 
            // mStartStop
            // 
            this.mStartStop.Name = "mStartStop";
            this.mStartStop.Size = new System.Drawing.Size(120, 22);
            this.mStartStop.Text = "Stop";
            this.mStartStop.Click += new System.EventHandler(this.mStartStop_Click);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(120, 22);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.myMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ChineseTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 247);
            this.ControlBox = false;
            this.Controls.Add(this.tbGerman);
            this.Controls.Add(this.tbPinyin);
            this.Controls.Add(this.tbChinese);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChineseTrainer";
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChineseTrainer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ChineseTrainer_Load);
            this.myMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox tbChinese;
        private System.Windows.Forms.TextBox tbPinyin;
        private System.Windows.Forms.TextBox tbGerman;
        private System.Windows.Forms.ContextMenuStrip myMenu;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mConfig;
        private System.Windows.Forms.ToolStripMenuItem mStartStop;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
    }
}

