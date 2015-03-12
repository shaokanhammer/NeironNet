namespace NeironNet
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabDemo = new System.Windows.Forms.TabPage();
            this.tabLearn = new System.Windows.Forms.TabPage();
            this.ButtonTeacher = new System.Windows.Forms.Button();
            this.GetResult = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.Incorrect = new System.Windows.Forms.Button();
            this.Correct = new System.Windows.Forms.Button();
            this.label002 = new System.Windows.Forms.Label();
            this.label001 = new System.Windows.Forms.Label();
            this.TeacherImage = new System.Windows.Forms.Button();
            this.TeacherDisplay = new System.Windows.Forms.PictureBox();
            this.MemoryDisplay = new System.Windows.Forms.PictureBox();
            this.NeironSelector = new System.Windows.Forms.ComboBox();
            this.TeachImageSelect = new System.Windows.Forms.OpenFileDialog();
            this.MainTabs.SuspendLayout();
            this.tabLearn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabs.Controls.Add(this.tabDemo);
            this.MainTabs.Controls.Add(this.tabLearn);
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.MaximumSize = new System.Drawing.Size(800, 500);
            this.MainTabs.MinimumSize = new System.Drawing.Size(800, 500);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(800, 500);
            this.MainTabs.TabIndex = 0;
            // 
            // tabDemo
            // 
            this.tabDemo.Location = new System.Drawing.Point(4, 22);
            this.tabDemo.Name = "tabDemo";
            this.tabDemo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDemo.Size = new System.Drawing.Size(792, 474);
            this.tabDemo.TabIndex = 0;
            this.tabDemo.Text = "Demo";
            this.tabDemo.UseVisualStyleBackColor = true;
            // 
            // tabLearn
            // 
            this.tabLearn.Controls.Add(this.ButtonTeacher);
            this.tabLearn.Controls.Add(this.GetResult);
            this.tabLearn.Controls.Add(this.LabelResult);
            this.tabLearn.Controls.Add(this.Incorrect);
            this.tabLearn.Controls.Add(this.Correct);
            this.tabLearn.Controls.Add(this.label002);
            this.tabLearn.Controls.Add(this.label001);
            this.tabLearn.Controls.Add(this.TeacherImage);
            this.tabLearn.Controls.Add(this.TeacherDisplay);
            this.tabLearn.Controls.Add(this.MemoryDisplay);
            this.tabLearn.Controls.Add(this.NeironSelector);
            this.tabLearn.Location = new System.Drawing.Point(4, 22);
            this.tabLearn.Name = "tabLearn";
            this.tabLearn.Padding = new System.Windows.Forms.Padding(3);
            this.tabLearn.Size = new System.Drawing.Size(792, 474);
            this.tabLearn.TabIndex = 1;
            this.tabLearn.Text = "Learn";
            this.tabLearn.UseVisualStyleBackColor = true;
            // 
            // ButtonTeacher
            // 
            this.ButtonTeacher.Location = new System.Drawing.Point(349, 181);
            this.ButtonTeacher.Name = "ButtonTeacher";
            this.ButtonTeacher.Size = new System.Drawing.Size(100, 21);
            this.ButtonTeacher.TabIndex = 12;
            this.ButtonTeacher.Text = "Example";
            this.ButtonTeacher.UseVisualStyleBackColor = true;
            this.ButtonTeacher.Click += new System.EventHandler(this.ButtonTeacher_Click);
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(349, 337);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(100, 23);
            this.GetResult.TabIndex = 11;
            this.GetResult.Text = "Calculate";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.Location = new System.Drawing.Point(300, 372);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(200, 13);
            this.LabelResult.TabIndex = 10;
            this.LabelResult.Text = "Result: match=MM% recocnized=RES";
            this.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Incorrect
            // 
            this.Incorrect.Location = new System.Drawing.Point(425, 408);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(75, 23);
            this.Incorrect.TabIndex = 9;
            this.Incorrect.Text = "Incorrect";
            this.Incorrect.UseVisualStyleBackColor = true;
            // 
            // Correct
            // 
            this.Correct.Location = new System.Drawing.Point(303, 408);
            this.Correct.Name = "Correct";
            this.Correct.Size = new System.Drawing.Size(75, 23);
            this.Correct.TabIndex = 8;
            this.Correct.Text = "Correct";
            this.Correct.UseVisualStyleBackColor = true;
            // 
            // label002
            // 
            this.label002.AutoSize = true;
            this.label002.Location = new System.Drawing.Point(544, 81);
            this.label002.Name = "label002";
            this.label002.Size = new System.Drawing.Size(44, 13);
            this.label002.TabIndex = 7;
            this.label002.Text = "Memory";
            // 
            // label001
            // 
            this.label001.AutoSize = true;
            this.label001.Location = new System.Drawing.Point(214, 81);
            this.label001.Name = "label001";
            this.label001.Size = new System.Drawing.Size(47, 13);
            this.label001.TabIndex = 6;
            this.label001.Text = "Teacher";
            // 
            // TeacherImage
            // 
            this.TeacherImage.Location = new System.Drawing.Point(181, 286);
            this.TeacherImage.Name = "TeacherImage";
            this.TeacherImage.Size = new System.Drawing.Size(115, 21);
            this.TeacherImage.TabIndex = 5;
            this.TeacherImage.Text = "Open image";
            this.TeacherImage.UseVisualStyleBackColor = true;
            this.TeacherImage.Click += new System.EventHandler(this.TeachNewImage_Click);
            // 
            // TeacherDisplay
            // 
            this.TeacherDisplay.InitialImage = null;
            this.TeacherDisplay.Location = new System.Drawing.Point(146, 100);
            this.TeacherDisplay.MaximumSize = new System.Drawing.Size(180, 180);
            this.TeacherDisplay.MinimumSize = new System.Drawing.Size(180, 180);
            this.TeacherDisplay.Name = "TeacherDisplay";
            this.TeacherDisplay.Size = new System.Drawing.Size(180, 180);
            this.TeacherDisplay.TabIndex = 4;
            this.TeacherDisplay.TabStop = false;
            // 
            // MemoryDisplay
            // 
            this.MemoryDisplay.InitialImage = null;
            this.MemoryDisplay.Location = new System.Drawing.Point(472, 100);
            this.MemoryDisplay.MaximumSize = new System.Drawing.Size(180, 180);
            this.MemoryDisplay.MinimumSize = new System.Drawing.Size(180, 180);
            this.MemoryDisplay.Name = "MemoryDisplay";
            this.MemoryDisplay.Size = new System.Drawing.Size(180, 180);
            this.MemoryDisplay.TabIndex = 3;
            this.MemoryDisplay.TabStop = false;
            // 
            // NeironSelector
            // 
            this.NeironSelector.AllowDrop = true;
            this.NeironSelector.FormattingEnabled = true;
            this.NeironSelector.Location = new System.Drawing.Point(349, 73);
            this.NeironSelector.Name = "NeironSelector";
            this.NeironSelector.Size = new System.Drawing.Size(100, 21);
            this.NeironSelector.TabIndex = 2;
            this.NeironSelector.Text = "Selec Neiron";
            this.NeironSelector.SelectedIndexChanged += new System.EventHandler(this.NeironSelector_SelectedIndexChanged);
            // 
            // TeachImageSelect
            // 
            this.TeachImageSelect.FileName = "TeachImageSelect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 502);
            this.Controls.Add(this.MainTabs);
            this.MaximumSize = new System.Drawing.Size(815, 540);
            this.MinimumSize = new System.Drawing.Size(815, 540);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTabs.ResumeLayout(false);
            this.tabLearn.ResumeLayout(false);
            this.tabLearn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage tabDemo;
        private System.Windows.Forms.TabPage tabLearn;
        private System.Windows.Forms.PictureBox MemoryDisplay;
        private System.Windows.Forms.ComboBox NeironSelector;
        private System.Windows.Forms.PictureBox TeacherDisplay;
        private System.Windows.Forms.Button TeacherImage;
        private System.Windows.Forms.OpenFileDialog TeachImageSelect;
        private System.Windows.Forms.Label label001;
        private System.Windows.Forms.Label label002;
        private System.Windows.Forms.Button Incorrect;
        private System.Windows.Forms.Button Correct;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.Button ButtonTeacher;
    }
}

