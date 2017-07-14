namespace StuManSys
{
    partial class Update
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
            this.Cancel = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RXCJText = new System.Windows.Forms.TextBox();
            this.SpecialText = new System.Windows.Forms.TextBox();
            this.JGText = new System.Windows.Forms.TextBox();
            this.MoneyCombo = new System.Windows.Forms.ComboBox();
            this.MajorCombo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MajorLabel = new System.Windows.Forms.Label();
            this.RXCJLabel = new System.Windows.Forms.Label();
            this.JGLabel = new System.Windows.Forms.Label();
            this.SpecialLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NumText = new System.Windows.Forms.TextBox();
            this.NoLabel = new System.Windows.Forms.Label();
            this.UpdataButton = new System.Windows.Forms.Button();
            this.PreButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(322, 401);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(74, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "退出";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(35, 347);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 4;
            this.FirstButton.Text = "第一条";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RXCJText);
            this.groupBox1.Controls.Add(this.SpecialText);
            this.groupBox1.Controls.Add(this.JGText);
            this.groupBox1.Controls.Add(this.MoneyCombo);
            this.groupBox1.Controls.Add(this.MajorCombo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Sex);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Controls.Add(this.MoneyLabel);
            this.groupBox1.Controls.Add(this.MajorLabel);
            this.groupBox1.Controls.Add(this.RXCJLabel);
            this.groupBox1.Controls.Add(this.JGLabel);
            this.groupBox1.Controls.Add(this.SpecialLabel);
            this.groupBox1.Controls.Add(this.BirthLabel);
            this.groupBox1.Controls.Add(this.SexLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.NumText);
            this.groupBox1.Controls.Add(this.NoLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 316);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // RXCJText
            // 
            this.RXCJText.Location = new System.Drawing.Point(106, 172);
            this.RXCJText.Name = "RXCJText";
            this.RXCJText.Size = new System.Drawing.Size(121, 21);
            this.RXCJText.TabIndex = 17;
            // 
            // SpecialText
            // 
            this.SpecialText.Location = new System.Drawing.Point(106, 127);
            this.SpecialText.Name = "SpecialText";
            this.SpecialText.Size = new System.Drawing.Size(121, 21);
            this.SpecialText.TabIndex = 16;
            // 
            // JGText
            // 
            this.JGText.Location = new System.Drawing.Point(329, 127);
            this.JGText.Name = "JGText";
            this.JGText.Size = new System.Drawing.Size(136, 21);
            this.JGText.TabIndex = 15;
            // 
            // MoneyCombo
            // 
            this.MoneyCombo.FormattingEnabled = true;
            this.MoneyCombo.Items.AddRange(new object[] {
            "否",
            "是"});
            this.MoneyCombo.Location = new System.Drawing.Point(106, 220);
            this.MoneyCombo.Name = "MoneyCombo";
            this.MoneyCombo.Size = new System.Drawing.Size(121, 20);
            this.MoneyCombo.TabIndex = 14;
            this.MoneyCombo.Text = "否";
            // 
            // MajorCombo
            // 
            this.MajorCombo.FormattingEnabled = true;
            this.MajorCombo.Location = new System.Drawing.Point(329, 172);
            this.MajorCombo.Name = "MajorCombo";
            this.MajorCombo.Size = new System.Drawing.Size(138, 20);
            this.MajorCombo.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(329, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 21);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // Sex
            // 
            this.Sex.AutoCompleteCustomSource.AddRange(new string[] {
            "男",
            "女"});
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.Sex.Location = new System.Drawing.Point(106, 78);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(121, 20);
            this.Sex.TabIndex = 11;
            this.Sex.TabStop = false;
            this.Sex.Text = "男";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(329, 24);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(141, 21);
            this.NameText.TabIndex = 10;
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(23, 228);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(77, 12);
            this.MoneyLabel.TabIndex = 9;
            this.MoneyLabel.Text = "是否有奖学金";
            // 
            // MajorLabel
            // 
            this.MajorLabel.AutoSize = true;
            this.MajorLabel.Location = new System.Drawing.Point(258, 180);
            this.MajorLabel.Name = "MajorLabel";
            this.MajorLabel.Size = new System.Drawing.Size(29, 12);
            this.MajorLabel.TabIndex = 8;
            this.MajorLabel.Text = "专业";
            // 
            // RXCJLabel
            // 
            this.RXCJLabel.AutoSize = true;
            this.RXCJLabel.Location = new System.Drawing.Point(23, 180);
            this.RXCJLabel.Name = "RXCJLabel";
            this.RXCJLabel.Size = new System.Drawing.Size(53, 12);
            this.RXCJLabel.TabIndex = 7;
            this.RXCJLabel.Text = "入学成绩";
            // 
            // JGLabel
            // 
            this.JGLabel.AutoSize = true;
            this.JGLabel.Location = new System.Drawing.Point(258, 130);
            this.JGLabel.Name = "JGLabel";
            this.JGLabel.Size = new System.Drawing.Size(29, 12);
            this.JGLabel.TabIndex = 6;
            this.JGLabel.Text = "籍贯";
            // 
            // SpecialLabel
            // 
            this.SpecialLabel.AutoSize = true;
            this.SpecialLabel.Location = new System.Drawing.Point(25, 130);
            this.SpecialLabel.Name = "SpecialLabel";
            this.SpecialLabel.Size = new System.Drawing.Size(29, 12);
            this.SpecialLabel.TabIndex = 5;
            this.SpecialLabel.Text = "民族";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(258, 82);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(53, 12);
            this.BirthLabel.TabIndex = 4;
            this.BirthLabel.Text = "出生日期";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(25, 82);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(29, 12);
            this.SexLabel.TabIndex = 3;
            this.SexLabel.Text = "性别";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(258, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 12);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "姓名";
            // 
            // NumText
            // 
            this.NumText.Enabled = false;
            this.NumText.Location = new System.Drawing.Point(106, 24);
            this.NumText.Name = "NumText";
            this.NumText.Size = new System.Drawing.Size(121, 21);
            this.NumText.TabIndex = 1;
            // 
            // NoLabel
            // 
            this.NoLabel.AutoSize = true;
            this.NoLabel.Location = new System.Drawing.Point(23, 33);
            this.NoLabel.Name = "NoLabel";
            this.NoLabel.Size = new System.Drawing.Size(29, 12);
            this.NoLabel.TabIndex = 0;
            this.NoLabel.Text = "学号";
            // 
            // UpdataButton
            // 
            this.UpdataButton.Location = new System.Drawing.Point(83, 403);
            this.UpdataButton.Name = "UpdataButton";
            this.UpdataButton.Size = new System.Drawing.Size(77, 25);
            this.UpdataButton.TabIndex = 6;
            this.UpdataButton.Text = "更新记录";
            this.UpdataButton.UseVisualStyleBackColor = true;
            this.UpdataButton.Click += new System.EventHandler(this.UpdataButton_Click);
            // 
            // PreButton
            // 
            this.PreButton.Location = new System.Drawing.Point(142, 347);
            this.PreButton.Name = "PreButton";
            this.PreButton.Size = new System.Drawing.Size(79, 23);
            this.PreButton.TabIndex = 7;
            this.PreButton.Text = "上一条";
            this.PreButton.UseVisualStyleBackColor = true;
            this.PreButton.Click += new System.EventHandler(this.PreButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(256, 347);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(83, 25);
            this.NextButton.TabIndex = 8;
            this.NextButton.Text = "下一条";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(374, 347);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(83, 25);
            this.LastButton.TabIndex = 18;
            this.LastButton.Text = "最后一条";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(203, 403);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(77, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "删除记录";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 436);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.PreButton);
            this.Controls.Add(this.UpdataButton);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Update";
            this.Text = "学籍信息修改";
            this.Load += new System.EventHandler(this.Update_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RXCJText;
        private System.Windows.Forms.TextBox SpecialText;
        private System.Windows.Forms.TextBox JGText;
        private System.Windows.Forms.ComboBox MoneyCombo;
        private System.Windows.Forms.ComboBox MajorCombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label MajorLabel;
        private System.Windows.Forms.Label RXCJLabel;
        private System.Windows.Forms.Label JGLabel;
        private System.Windows.Forms.Label SpecialLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NumText;
        private System.Windows.Forms.Label NoLabel;
        private System.Windows.Forms.Button UpdataButton;
        private System.Windows.Forms.Button PreButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}