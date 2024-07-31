namespace MyPasswordGenerator
{
    partial class MyPasswordGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPasswordGenerator));
            GeneratePass_Btn = new Button();
            PassLength_NumUpDown = new NumericUpDown();
            Uppercase_Chkbox = new CheckBox();
            GeneratedPass_Txtbox = new TextBox();
            Lowercase_Chkbox = new CheckBox();
            Digits_Chkbox = new CheckBox();
            Special_Chkbox = new CheckBox();
            Brackets_Chkbox = new CheckBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            CopyPass_Btn = new Button();
            toolStrip1 = new ToolStrip();
            ToolBtnFile = new ToolStripDropDownButton();
            ToolBtnSaveAs = new ToolStripMenuItem();
            ToolBtnSettings = new ToolStripDropDownButton();
            ToolBtnClearHistory = new ToolStripMenuItem();
            ToolBtnCloseApp = new ToolStripButton();
            toolStripButton2 = new ToolStripDropDownButton();
            PassListboxHistory = new ListBox();
            PbarStrength = new ProgressBar();
            lblStrength = new Label();
            ((System.ComponentModel.ISupportInitialize)PassLength_NumUpDown).BeginInit();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GeneratePass_Btn
            // 
            GeneratePass_Btn.Location = new Point(27, 218);
            GeneratePass_Btn.Name = "GeneratePass_Btn";
            GeneratePass_Btn.Size = new Size(85, 23);
            GeneratePass_Btn.TabIndex = 0;
            GeneratePass_Btn.Text = "Generate";
            GeneratePass_Btn.UseVisualStyleBackColor = true;
            GeneratePass_Btn.Click += GeneratePass_Btn_Click;
            // 
            // PassLength_NumUpDown
            // 
            PassLength_NumUpDown.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassLength_NumUpDown.Location = new Point(181, 33);
            PassLength_NumUpDown.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            PassLength_NumUpDown.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            PassLength_NumUpDown.Name = "PassLength_NumUpDown";
            PassLength_NumUpDown.Size = new Size(58, 21);
            PassLength_NumUpDown.TabIndex = 1;
            PassLength_NumUpDown.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // Uppercase_Chkbox
            // 
            Uppercase_Chkbox.AutoSize = true;
            Uppercase_Chkbox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Uppercase_Chkbox.Location = new Point(6, 20);
            Uppercase_Chkbox.Name = "Uppercase_Chkbox";
            Uppercase_Chkbox.Size = new Size(93, 19);
            Uppercase_Chkbox.TabIndex = 2;
            Uppercase_Chkbox.Text = "Upper Case";
            Uppercase_Chkbox.UseVisualStyleBackColor = true;
            // 
            // GeneratedPass_Txtbox
            // 
            GeneratedPass_Txtbox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GeneratedPass_Txtbox.Location = new Point(9, 194);
            GeneratedPass_Txtbox.Name = "GeneratedPass_Txtbox";
            GeneratedPass_Txtbox.Size = new Size(230, 22);
            GeneratedPass_Txtbox.TabIndex = 3;
            // 
            // Lowercase_Chkbox
            // 
            Lowercase_Chkbox.AutoSize = true;
            Lowercase_Chkbox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lowercase_Chkbox.Location = new Point(6, 45);
            Lowercase_Chkbox.Name = "Lowercase_Chkbox";
            Lowercase_Chkbox.Size = new Size(93, 19);
            Lowercase_Chkbox.TabIndex = 4;
            Lowercase_Chkbox.Text = "Lower Case";
            Lowercase_Chkbox.UseVisualStyleBackColor = true;
            // 
            // Digits_Chkbox
            // 
            Digits_Chkbox.AutoSize = true;
            Digits_Chkbox.Font = new Font("Arial", 9F);
            Digits_Chkbox.Location = new Point(105, 20);
            Digits_Chkbox.Name = "Digits_Chkbox";
            Digits_Chkbox.Size = new Size(58, 19);
            Digits_Chkbox.TabIndex = 5;
            Digits_Chkbox.Text = "Digits";
            Digits_Chkbox.UseVisualStyleBackColor = true;
            // 
            // Special_Chkbox
            // 
            Special_Chkbox.AutoSize = true;
            Special_Chkbox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Special_Chkbox.Location = new Point(6, 70);
            Special_Chkbox.Name = "Special_Chkbox";
            Special_Chkbox.Size = new Size(67, 19);
            Special_Chkbox.TabIndex = 6;
            Special_Chkbox.Text = "Special";
            Special_Chkbox.UseVisualStyleBackColor = true;
            // 
            // Brackets_Chkbox
            // 
            Brackets_Chkbox.AutoSize = true;
            Brackets_Chkbox.Font = new Font("Arial", 9F);
            Brackets_Chkbox.Location = new Point(105, 45);
            Brackets_Chkbox.Name = "Brackets_Chkbox";
            Brackets_Chkbox.Size = new Size(74, 19);
            Brackets_Chkbox.TabIndex = 7;
            Brackets_Chkbox.Text = "Brackets";
            Brackets_Chkbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 8;
            label1.Text = "Password Length:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Uppercase_Chkbox);
            groupBox1.Controls.Add(Lowercase_Chkbox);
            groupBox1.Controls.Add(Special_Chkbox);
            groupBox1.Controls.Add(Brackets_Chkbox);
            groupBox1.Controls.Add(Digits_Chkbox);
            groupBox1.Location = new Point(9, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(230, 92);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Characters To Include:";
            // 
            // CopyPass_Btn
            // 
            CopyPass_Btn.Location = new Point(161, 218);
            CopyPass_Btn.Name = "CopyPass_Btn";
            CopyPass_Btn.Size = new Size(49, 23);
            CopyPass_Btn.TabIndex = 15;
            CopyPass_Btn.Text = "Copy";
            CopyPass_Btn.UseVisualStyleBackColor = true;
            CopyPass_Btn.Click += CopyPass_Btn_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.DarkTurquoise;
            toolStrip1.Items.AddRange(new ToolStripItem[] { ToolBtnFile, ToolBtnSettings, ToolBtnCloseApp });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(263, 25);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // ToolBtnFile
            // 
            ToolBtnFile.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolBtnFile.DropDownItems.AddRange(new ToolStripItem[] { ToolBtnSaveAs });
            ToolBtnFile.Image = (Image)resources.GetObject("ToolBtnFile.Image");
            ToolBtnFile.ImageTransparentColor = Color.Magenta;
            ToolBtnFile.Name = "ToolBtnFile";
            ToolBtnFile.Size = new Size(38, 22);
            ToolBtnFile.Text = "File";
            // 
            // ToolBtnSaveAs
            // 
            ToolBtnSaveAs.Name = "ToolBtnSaveAs";
            ToolBtnSaveAs.Size = new Size(114, 22);
            ToolBtnSaveAs.Text = "Save As";
            // 
            // ToolBtnSettings
            // 
            ToolBtnSettings.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolBtnSettings.DropDownItems.AddRange(new ToolStripItem[] { ToolBtnClearHistory });
            ToolBtnSettings.Image = (Image)resources.GetObject("ToolBtnSettings.Image");
            ToolBtnSettings.ImageTransparentColor = Color.Magenta;
            ToolBtnSettings.Name = "ToolBtnSettings";
            ToolBtnSettings.Size = new Size(62, 22);
            ToolBtnSettings.Text = "Settings";
            // 
            // ToolBtnClearHistory
            // 
            ToolBtnClearHistory.Name = "ToolBtnClearHistory";
            ToolBtnClearHistory.Size = new Size(142, 22);
            ToolBtnClearHistory.Text = "Clear History";
            ToolBtnClearHistory.Click += ToolBtnClearHistory_Click;
            // 
            // ToolBtnCloseApp
            // 
            ToolBtnCloseApp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ToolBtnCloseApp.Image = (Image)resources.GetObject("ToolBtnCloseApp.Image");
            ToolBtnCloseApp.ImageTransparentColor = Color.Magenta;
            ToolBtnCloseApp.Name = "ToolBtnCloseApp";
            ToolBtnCloseApp.Size = new Size(65, 22);
            ToolBtnCloseApp.Text = "Close App";
            ToolBtnCloseApp.Click += ToolBtnCloseApp_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(86, 22);
            toolStripButton2.Text = "View History";
            // 
            // PassListboxHistory
            // 
            PassListboxHistory.FormattingEnabled = true;
            PassListboxHistory.ItemHeight = 15;
            PassListboxHistory.Location = new Point(9, 263);
            PassListboxHistory.Name = "PassListboxHistory";
            PassListboxHistory.Size = new Size(225, 94);
            PassListboxHistory.TabIndex = 17;
            // 
            // PbarStrength
            // 
            PbarStrength.Location = new Point(9, 176);
            PbarStrength.Name = "PbarStrength";
            PbarStrength.Size = new Size(230, 12);
            PbarStrength.TabIndex = 18;
            // 
            // lblStrength
            // 
            lblStrength.AutoSize = true;
            lblStrength.Font = new Font("Arial", 9F);
            lblStrength.Location = new Point(9, 158);
            lblStrength.Name = "lblStrength";
            lblStrength.Size = new Size(136, 15);
            lblStrength.TabIndex = 19;
            lblStrength.Text = "Password Strength: 0%";
            // 
            // MyPasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(263, 381);
            Controls.Add(lblStrength);
            Controls.Add(PbarStrength);
            Controls.Add(PassListboxHistory);
            Controls.Add(toolStrip1);
            Controls.Add(CopyPass_Btn);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(GeneratedPass_Txtbox);
            Controls.Add(PassLength_NumUpDown);
            Controls.Add(GeneratePass_Btn);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MyPasswordGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)PassLength_NumUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GeneratePass_Btn;
        private NumericUpDown PassLength_NumUpDown;
        private CheckBox Uppercase_Chkbox;
        private TextBox GeneratedPass_Txtbox;
        private CheckBox Lowercase_Chkbox;
        private CheckBox Digits_Chkbox;
        private CheckBox Special_Chkbox;
        private CheckBox Brackets_Chkbox;
        private Label label1;
        private GroupBox groupBox1;
        private ToolStripMenuItem ToolBtnSaveAs;
        private Button CopyPass_Btn;
        private ToolStrip toolStrip1;
        private ToolStripButton ToolBtnCloseApp;
        private ToolStripDropDownButton toolStripButton2;
        private ListBox PassListboxHistory;
        private ProgressBar PbarStrength;
        private Label lblStrength;
        private ToolStripDropDownButton ToolBtnFile;
        private ToolStripDropDownButton ToolBtnSettings;
        private ToolStripMenuItem ToolBtnClearHistory;
    }
}
