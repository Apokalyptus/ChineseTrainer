namespace ChineseTrainer
{
    partial class PropEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChapterList = new System.Windows.Forms.TextBox();
            this.rbChoiceSelection = new System.Windows.Forms.RadioButton();
            this.rbChoiceAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSequence = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbFadeTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbShowHideTime = new System.Windows.Forms.TextBox();
            this.config2 = new global::ChineseTrainer.Properties.DataSources.Config();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbChapterList);
            this.groupBox1.Controls.Add(this.rbChoiceSelection);
            this.groupBox1.Controls.Add(this.rbChoiceAll);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Vocabulary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(184, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "(1,2,..)";
            // 
            // tbChapterList
            // 
            this.tbChapterList.Location = new System.Drawing.Point(71, 41);
            this.tbChapterList.Name = "tbChapterList";
            this.tbChapterList.ReadOnly = true;
            this.tbChapterList.Size = new System.Drawing.Size(113, 20);
            this.tbChapterList.TabIndex = 2;
            this.tbChapterList.TextChanged += new System.EventHandler(this.ChapterTextChanged);
            // 
            // rbChoiceSelection
            // 
            this.rbChoiceSelection.AutoSize = true;
            this.rbChoiceSelection.Location = new System.Drawing.Point(6, 42);
            this.rbChoiceSelection.Name = "rbChoiceSelection";
            this.rbChoiceSelection.Size = new System.Drawing.Size(62, 17);
            this.rbChoiceSelection.TabIndex = 1;
            this.rbChoiceSelection.Text = "Chapter";
            this.rbChoiceSelection.UseVisualStyleBackColor = true;
            this.rbChoiceSelection.CheckedChanged += new System.EventHandler(this.ChapterSelected);
            // 
            // rbChoiceAll
            // 
            this.rbChoiceAll.AutoSize = true;
            this.rbChoiceAll.Checked = true;
            this.rbChoiceAll.Location = new System.Drawing.Point(6, 19);
            this.rbChoiceAll.Name = "rbChoiceAll";
            this.rbChoiceAll.Size = new System.Drawing.Size(36, 17);
            this.rbChoiceAll.TabIndex = 0;
            this.rbChoiceAll.TabStop = true;
            this.rbChoiceAll.Text = "All";
            this.rbChoiceAll.UseVisualStyleBackColor = true;
            this.rbChoiceAll.CheckedChanged += new System.EventHandler(this.AllSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSequence);
            this.groupBox2.Controls.Add(this.rbRandom);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sequence";
            // 
            // rbSequence
            // 
            this.rbSequence.AutoSize = true;
            this.rbSequence.Location = new System.Drawing.Point(7, 43);
            this.rbSequence.Name = "rbSequence";
            this.rbSequence.Size = new System.Drawing.Size(85, 17);
            this.rbSequence.TabIndex = 1;
            this.rbSequence.Text = "in Sequence";
            this.rbSequence.UseVisualStyleBackColor = true;
            this.rbSequence.CheckedChanged += new System.EventHandler(this.ChoseSequence);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(7, 20);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(72, 17);
            this.rbRandom.TabIndex = 0;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Randomly";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.ChoseRandom);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(83, 208);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "OK";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.SaveConfiguration);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbFadeTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbShowHideTime);
            this.groupBox3.Location = new System.Drawing.Point(12, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 40);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // tbFadeTime
            // 
            this.tbFadeTime.Location = new System.Drawing.Point(160, 13);
            this.tbFadeTime.MaxLength = 5;
            this.tbFadeTime.Name = "tbFadeTime";
            this.tbFadeTime.Size = new System.Drawing.Size(46, 20);
            this.tbFadeTime.TabIndex = 3;
            this.tbFadeTime.Text = "100";
            this.tbFadeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFadeTime.TextChanged += new System.EventHandler(this.ChangedFadeInOutTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Show/Hide";
            // 
            // tbShowHideTime
            // 
            this.tbShowHideTime.Location = new System.Drawing.Point(71, 13);
            this.tbShowHideTime.MaxLength = 5;
            this.tbShowHideTime.Name = "tbShowHideTime";
            this.tbShowHideTime.Size = new System.Drawing.Size(46, 20);
            this.tbShowHideTime.TabIndex = 0;
            this.tbShowHideTime.Text = "3000";
            this.tbShowHideTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbShowHideTime.TextChanged += new System.EventHandler(this.ChangedShowHideTime);
            // 
            // config2
            // 
            this.config2.DataSetName = "Config";
            this.config2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PropEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 237);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.PropEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.config2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbChoiceSelection;
        private System.Windows.Forms.RadioButton rbChoiceAll;
        private System.Windows.Forms.TextBox tbChapterList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSequence;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbShowHideTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFadeTime;
        private System.Windows.Forms.Label label3;
        private global::ChineseTrainer.Properties.DataSources.Config config2;
    }
}