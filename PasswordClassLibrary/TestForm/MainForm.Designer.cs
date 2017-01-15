namespace TestForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.passCountTextBox = new System.Windows.Forms.TextBox();
            this.mulPassCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.digit2UpDown = new System.Windows.Forms.NumericUpDown();
            this.digit1UpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.uTo = new System.Windows.Forms.Label();
            this.uFrom = new System.Windows.Forms.Label();
            this.upCheckBox = new System.Windows.Forms.CheckBox();
            this.lTo = new System.Windows.Forms.Label();
            this.lFrom = new System.Windows.Forms.Label();
            this.lowCheckBox = new System.Windows.Forms.CheckBox();
            this.dTo = new System.Windows.Forms.Label();
            this.dFrom = new System.Windows.Forms.Label();
            this.digitCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.mainButton = new System.Windows.Forms.Button();
            this.lComboBox1 = new System.Windows.Forms.ComboBox();
            this.lComboBox2 = new System.Windows.Forms.ComboBox();
            this.uComboBox1 = new System.Windows.Forms.ComboBox();
            this.uComboBox2 = new System.Windows.Forms.ComboBox();
            this.SettingsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.passCountTextBox);
            this.SettingsGroupBox.Controls.Add(this.mulPassCheckBox);
            this.SettingsGroupBox.Controls.Add(this.groupBox2);
            this.SettingsGroupBox.Controls.Add(this.label1);
            this.SettingsGroupBox.Controls.Add(this.lengthUpDown);
            this.SettingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(321, 349);
            this.SettingsGroupBox.TabIndex = 0;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // passCountTextBox
            // 
            this.passCountTextBox.Enabled = false;
            this.passCountTextBox.Location = new System.Drawing.Point(203, 312);
            this.passCountTextBox.Name = "passCountTextBox";
            this.passCountTextBox.Size = new System.Drawing.Size(40, 21);
            this.passCountTextBox.TabIndex = 15;
            // 
            // mulPassCheckBox
            // 
            this.mulPassCheckBox.AutoSize = true;
            this.mulPassCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mulPassCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.mulPassCheckBox.Location = new System.Drawing.Point(52, 312);
            this.mulPassCheckBox.Name = "mulPassCheckBox";
            this.mulPassCheckBox.Size = new System.Drawing.Size(145, 20);
            this.mulPassCheckBox.TabIndex = 3;
            this.mulPassCheckBox.Text = "Multiple passwords:";
            this.mulPassCheckBox.UseVisualStyleBackColor = true;
            this.mulPassCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mulPassCheckBox_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uComboBox2);
            this.groupBox2.Controls.Add(this.uComboBox1);
            this.groupBox2.Controls.Add(this.lComboBox2);
            this.groupBox2.Controls.Add(this.lComboBox1);
            this.groupBox2.Controls.Add(this.digit2UpDown);
            this.groupBox2.Controls.Add(this.digit1UpDown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.uTo);
            this.groupBox2.Controls.Add(this.uFrom);
            this.groupBox2.Controls.Add(this.upCheckBox);
            this.groupBox2.Controls.Add(this.lTo);
            this.groupBox2.Controls.Add(this.lFrom);
            this.groupBox2.Controls.Add(this.lowCheckBox);
            this.groupBox2.Controls.Add(this.dTo);
            this.groupBox2.Controls.Add(this.dFrom);
            this.groupBox2.Controls.Add(this.digitCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(19, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 244);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // digit2UpDown
            // 
            this.digit2UpDown.Location = new System.Drawing.Point(184, 46);
            this.digit2UpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit2UpDown.Name = "digit2UpDown";
            this.digit2UpDown.Size = new System.Drawing.Size(39, 21);
            this.digit2UpDown.TabIndex = 17;
            this.digit2UpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // digit1UpDown
            // 
            this.digit1UpDown.Location = new System.Drawing.Point(94, 46);
            this.digit1UpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit1UpDown.Name = "digit1UpDown";
            this.digit1UpDown.Size = new System.Drawing.Size(39, 21);
            this.digit1UpDown.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(40, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Note: You must check at least one !";
            // 
            // uTo
            // 
            this.uTo.AutoSize = true;
            this.uTo.Enabled = false;
            this.uTo.Location = new System.Drawing.Point(157, 172);
            this.uTo.Name = "uTo";
            this.uTo.Size = new System.Drawing.Size(20, 15);
            this.uTo.TabIndex = 13;
            this.uTo.Text = "to:";
            // 
            // uFrom
            // 
            this.uFrom.AutoSize = true;
            this.uFrom.Enabled = false;
            this.uFrom.Location = new System.Drawing.Point(52, 172);
            this.uFrom.Name = "uFrom";
            this.uFrom.Size = new System.Drawing.Size(35, 15);
            this.uFrom.TabIndex = 12;
            this.uFrom.Text = "from:";
            // 
            // upCheckBox
            // 
            this.upCheckBox.AutoSize = true;
            this.upCheckBox.Location = new System.Drawing.Point(18, 148);
            this.upCheckBox.Name = "upCheckBox";
            this.upCheckBox.Size = new System.Drawing.Size(145, 19);
            this.upCheckBox.TabIndex = 10;
            this.upCheckBox.Text = "Use uppercase letters";
            this.upCheckBox.UseVisualStyleBackColor = true;
            this.upCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.upCheckBox_MouseClick);
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Enabled = false;
            this.lTo.Location = new System.Drawing.Point(158, 109);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(20, 15);
            this.lTo.TabIndex = 8;
            this.lTo.Text = "to:";
            // 
            // lFrom
            // 
            this.lFrom.AutoSize = true;
            this.lFrom.Enabled = false;
            this.lFrom.Location = new System.Drawing.Point(52, 109);
            this.lFrom.Name = "lFrom";
            this.lFrom.Size = new System.Drawing.Size(35, 15);
            this.lFrom.TabIndex = 7;
            this.lFrom.Text = "from:";
            // 
            // lowCheckBox
            // 
            this.lowCheckBox.AutoSize = true;
            this.lowCheckBox.Location = new System.Drawing.Point(18, 85);
            this.lowCheckBox.Name = "lowCheckBox";
            this.lowCheckBox.Size = new System.Drawing.Size(143, 19);
            this.lowCheckBox.TabIndex = 5;
            this.lowCheckBox.Text = "Use lowercase letters";
            this.lowCheckBox.UseVisualStyleBackColor = true;
            this.lowCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lowCheckBox_MouseClick);
            // 
            // dTo
            // 
            this.dTo.AutoSize = true;
            this.dTo.Location = new System.Drawing.Point(157, 45);
            this.dTo.Name = "dTo";
            this.dTo.Size = new System.Drawing.Size(20, 15);
            this.dTo.TabIndex = 3;
            this.dTo.Text = "to:";
            // 
            // dFrom
            // 
            this.dFrom.AutoSize = true;
            this.dFrom.Location = new System.Drawing.Point(52, 45);
            this.dFrom.Name = "dFrom";
            this.dFrom.Size = new System.Drawing.Size(35, 15);
            this.dFrom.TabIndex = 2;
            this.dFrom.Text = "from:";
            // 
            // digitCheckBox
            // 
            this.digitCheckBox.AutoSize = true;
            this.digitCheckBox.Checked = true;
            this.digitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digitCheckBox.Location = new System.Drawing.Point(18, 20);
            this.digitCheckBox.Name = "digitCheckBox";
            this.digitCheckBox.Size = new System.Drawing.Size(80, 19);
            this.digitCheckBox.TabIndex = 0;
            this.digitCheckBox.Text = "Use digits";
            this.digitCheckBox.UseVisualStyleBackColor = true;
            this.digitCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.digitCheckBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Length:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Location = new System.Drawing.Point(158, 24);
            this.lengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(67, 21);
            this.lengthUpDown.TabIndex = 0;
            this.lengthUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.mainButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generated password";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(7, 26);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(308, 22);
            this.resultTextBox.TabIndex = 1;
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(80, 65);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(162, 31);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Generate";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainButton_MouseClick);
            // 
            // lComboBox1
            // 
            this.lComboBox1.Enabled = false;
            this.lComboBox1.FormattingEnabled = true;
            this.lComboBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.lComboBox1.Location = new System.Drawing.Point(93, 106);
            this.lComboBox1.Name = "lComboBox1";
            this.lComboBox1.Size = new System.Drawing.Size(39, 23);
            this.lComboBox1.TabIndex = 18;
            this.lComboBox1.Text = "a";
            // 
            // lComboBox2
            // 
            this.lComboBox2.Enabled = false;
            this.lComboBox2.FormattingEnabled = true;
            this.lComboBox2.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.lComboBox2.Location = new System.Drawing.Point(184, 106);
            this.lComboBox2.Name = "lComboBox2";
            this.lComboBox2.Size = new System.Drawing.Size(39, 23);
            this.lComboBox2.TabIndex = 19;
            this.lComboBox2.Text = "z";
            // 
            // uComboBox1
            // 
            this.uComboBox1.Enabled = false;
            this.uComboBox1.FormattingEnabled = true;
            this.uComboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.uComboBox1.Location = new System.Drawing.Point(93, 173);
            this.uComboBox1.Name = "uComboBox1";
            this.uComboBox1.Size = new System.Drawing.Size(39, 23);
            this.uComboBox1.TabIndex = 20;
            this.uComboBox1.Text = "A";
            // 
            // uComboBox2
            // 
            this.uComboBox2.Enabled = false;
            this.uComboBox2.FormattingEnabled = true;
            this.uComboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.uComboBox2.Location = new System.Drawing.Point(183, 173);
            this.uComboBox2.Name = "uComboBox2";
            this.uComboBox2.Size = new System.Drawing.Size(39, 23);
            this.uComboBox2.TabIndex = 21;
            this.uComboBox2.Text = "Z";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SettingsGroupBox);
            this.Name = "MainForm";
            this.Text = "Password Generator";
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label uTo;
        private System.Windows.Forms.Label uFrom;
        private System.Windows.Forms.CheckBox upCheckBox;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.Label lFrom;
        private System.Windows.Forms.CheckBox lowCheckBox;
        private System.Windows.Forms.Label dTo;
        private System.Windows.Forms.Label dFrom;
        private System.Windows.Forms.CheckBox digitCheckBox;
        private System.Windows.Forms.TextBox passCountTextBox;
        private System.Windows.Forms.CheckBox mulPassCheckBox;
        private System.Windows.Forms.NumericUpDown digit2UpDown;
        private System.Windows.Forms.NumericUpDown digit1UpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.ComboBox uComboBox2;
        private System.Windows.Forms.ComboBox uComboBox1;
        private System.Windows.Forms.ComboBox lComboBox2;
        private System.Windows.Forms.ComboBox lComboBox1;
    }
}

