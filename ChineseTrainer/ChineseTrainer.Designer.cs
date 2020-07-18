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
            this.trainingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.mDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mStartStop = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataSet1 = new global::ChineseTrainer.Properties.DataSources.Vocabulary();
            this.laPosition = new System.Windows.Forms.Label();
            this.config1 = new global::ChineseTrainer.Properties.DataSources.Config();
            this.tbWelcome = new System.Windows.Forms.TextBox();
            this.myMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.config1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.FadeInOutTimer);
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.PauseTimer);
            // 
            // tbChinese
            // 
            this.tbChinese.BackColor = System.Drawing.Color.White;
            this.tbChinese.Enabled = false;
            this.tbChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChinese.Location = new System.Drawing.Point(13, 12);
            this.tbChinese.Name = "tbChinese";
            this.tbChinese.ReadOnly = true;
            this.tbChinese.Size = new System.Drawing.Size(267, 98);
            this.tbChinese.TabIndex = 3;
            this.tbChinese.Text = "爸爸爸";
            this.tbChinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPinyin
            // 
            this.tbPinyin.AcceptsReturn = true;
            this.tbPinyin.BackColor = System.Drawing.Color.White;
            this.tbPinyin.Enabled = false;
            this.tbPinyin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPinyin.Location = new System.Drawing.Point(13, 114);
            this.tbPinyin.Multiline = true;
            this.tbPinyin.Name = "tbPinyin";
            this.tbPinyin.ReadOnly = true;
            this.tbPinyin.Size = new System.Drawing.Size(267, 57);
            this.tbPinyin.TabIndex = 4;
            this.tbPinyin.Text = "1234567890";
            this.tbPinyin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbGerman
            // 
            this.tbGerman.AcceptsReturn = true;
            this.tbGerman.BackColor = System.Drawing.Color.White;
            this.tbGerman.Enabled = false;
            this.tbGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGerman.Location = new System.Drawing.Point(13, 175);
            this.tbGerman.Multiline = true;
            this.tbGerman.Name = "tbGerman";
            this.tbGerman.ReadOnly = true;
            this.tbGerman.Size = new System.Drawing.Size(267, 57);
            this.tbGerman.TabIndex = 5;
            this.tbGerman.Text = "123456789012345678901234567890";
            this.tbGerman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // myMenu
            // 
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainingModeToolStripMenuItem,
            this.mDatabase,
            this.mConfig,
            this.mStartStop,
            this.aboutToolStripMenuItem,
            this.mExit});
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(142, 136);
            // 
            // trainingModeToolStripMenuItem
            // 
            this.trainingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.trainingModeToolStripMenuItem.Name = "trainingModeToolStripMenuItem";
            this.trainingModeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trainingModeToolStripMenuItem.Text = "Training Mode";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "off",
            "HanZi",
            "PinYin",
            "German",
            "Random G/P"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 21);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.ChangeTrainigMode);
            // 
            // mDatabase
            // 
            this.mDatabase.Name = "mDatabase";
            this.mDatabase.Size = new System.Drawing.Size(152, 22);
            this.mDatabase.Text = "Database";
            this.mDatabase.Click += new System.EventHandler(this.ShowVocabularyEditorDialog);
            // 
            // mConfig
            // 
            this.mConfig.Name = "mConfig";
            this.mConfig.Size = new System.Drawing.Size(152, 22);
            this.mConfig.Text = "Config";
            this.mConfig.Click += new System.EventHandler(this.ShowConfigurationDialog);
            // 
            // mStartStop
            // 
            this.mStartStop.Name = "mStartStop";
            this.mStartStop.Size = new System.Drawing.Size(152, 22);
            this.mStartStop.Text = "Stop";
            this.mStartStop.Click += new System.EventHandler(this.StartStop);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ShowAboutDialog);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(152, 22);
            this.mExit.Text = "Exit";
            this.mExit.Click += new System.EventHandler(this.Exit);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.myMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laPosition
            // 
            this.laPosition.AutoSize = true;
            this.laPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPosition.Location = new System.Drawing.Point(12, 235);
            this.laPosition.Name = "laPosition";
            this.laPosition.Size = new System.Drawing.Size(19, 9);
            this.laPosition.TabIndex = 6;
            this.laPosition.Text = "1 / 1";
            // 
            // config1
            // 
            this.config1.DataSetName = "Config";
            this.config1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbWelcome
            // 
            this.tbWelcome.AcceptsReturn = true;
            this.tbWelcome.BackColor = System.Drawing.Color.White;
            this.tbWelcome.Enabled = false;
            this.tbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWelcome.Location = new System.Drawing.Point(13, 12);
            this.tbWelcome.Multiline = true;
            this.tbWelcome.Name = "tbWelcome";
            this.tbWelcome.ReadOnly = true;
            this.tbWelcome.Size = new System.Drawing.Size(28, 29);
            this.tbWelcome.TabIndex = 7;
            this.tbWelcome.Text = "Welcome\\r\\nto\\r\\nChineseTrainer";
            this.tbWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChineseTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 247);
            this.ControlBox = false;
            this.Controls.Add(this.tbWelcome);
            this.Controls.Add(this.laPosition);
            this.Controls.Add(this.tbPinyin);
            this.Controls.Add(this.tbGerman);
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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChineseTrainer_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChineseTrainer_KeyDown);
            this.myMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.config1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem mDatabase;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label laPosition;
        private global::ChineseTrainer.Properties.DataSources.Config config1;
        private System.Windows.Forms.TextBox tbWelcome;
        private global::ChineseTrainer.Properties.DataSources.Vocabulary dataSet1;
        private System.Windows.Forms.ToolStripMenuItem trainingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

